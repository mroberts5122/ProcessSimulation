using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace ProcessSimulation
{
	public class Simulation
	{
		readonly Stopwatch sw;
		long totalTicks;

		readonly Random rnd;
		readonly System.Timers.Timer tmr;
		int minuteCount;

		readonly frmMain frm;
		readonly int operatorCount;
		readonly int scannerCount;
		readonly int minimumProcessingMinutes;
		readonly int maximumProcessingMinutes;
		readonly int minimumScanningMinutes;
		readonly int maximumScanningMinutes;
		readonly int boxCountPerTruck;
		readonly int newTruckInterval;
		readonly int millisecondsPerSimulatedMinutes;
		readonly int simulationMinutesTotal;

		readonly List<Box> allBoxes;
		readonly List<Operator> operators;
		readonly Queue<Box> scanningQueue;
		readonly List<Scanner> scanners;
		readonly Queue<Box> loadingQueue;
		readonly List<Truck> trucks;

		public Simulation(frmMain _frm, int _operatorCount, int _scannerCount, int _minimumProcessingMinutes, int _maximumProcessingMinutes, int _minimumScanningMinutes, int _maximumScanningMinutes, int _boxCountPerTruck, int _newTruckInterval, int _millisecondsPerSimulatedMinutes, int _simulationMinutesTotal)
		{
			sw = new Stopwatch();
			totalTicks = 0;

			frm = _frm;
			operatorCount = _operatorCount;
			scannerCount = _scannerCount;
			minimumProcessingMinutes = _minimumProcessingMinutes;
			maximumProcessingMinutes = _maximumProcessingMinutes;
			minimumScanningMinutes = _minimumScanningMinutes;
			maximumScanningMinutes = _maximumScanningMinutes;
			boxCountPerTruck = _boxCountPerTruck;
			newTruckInterval = _newTruckInterval;
			millisecondsPerSimulatedMinutes = _millisecondsPerSimulatedMinutes;
			simulationMinutesTotal = _simulationMinutesTotal;


			rnd = new Random();
			tmr = new System.Timers.Timer(millisecondsPerSimulatedMinutes);
			tmr.Elapsed += OnSimulationMinute;
			tmr.AutoReset = false;
			minuteCount = 0;

			operators = new List<Operator>(operatorCount);
			for (var oi = 0; oi < operatorCount; oi++)
			{
				var oper = new Operator();
				operators.Add(oper);
				var lio = new ListViewItem(new[] { oper.OperatorId.ToString(), "0", "0", "0", "0" })
				{
					Tag = oper
				};
				if (frm.lvwOperatorStatistics.IsHandleCreated)
				{
					frm.lvwOperatorStatistics.BeginInvoke(new Action(() => frm.lvwOperatorStatistics.Items.Add(lio)));
					oper.ListViewItem = lio;
				}
			}

			scanners = new List<Scanner>(scannerCount);
			for (var si = 0; si < scannerCount; si++)
			{
				var scan = new Scanner();
				scanners.Add(scan);
				var lis = new ListViewItem(new[] { scan.ScannerId.ToString(), "0", "0", "0", "0" })
				{
					Tag = scan
				};
				if (frm.lvwScannerStatistics.IsHandleCreated)
				{
					frm.lvwScannerStatistics.BeginInvoke(new Action(() => frm.lvwScannerStatistics.Items.Add(lis)));
					scan.ListViewItem = lis;
				}
			}

			trucks = new List<Truck>();
			var truck = new Truck();
			trucks.Add(truck);
			var li = new ListViewItem(new[] { truck.TruckId.ToString(), "0", "0", "0", "false" })
			{
				Tag = truck
			};
			truck.ListViewItem = li;
			if (frm.lvwTruckStatistics.IsHandleCreated)
			{
				frm.lvwTruckStatistics.BeginInvoke(new Action(() => frm.lvwTruckStatistics.Items.Add(li)));
			}


			allBoxes = new List<Box>();
			scanningQueue = new Queue<Box>();
			loadingQueue = new Queue<Box>();
		}

		public void Start()
		{
			tmr.Start();
		}

		private void OnSimulationMinute(object source, ElapsedEventArgs e)
		{
			tmr.Stop();
			minuteCount++;

			sw.Restart();

			if (frm.lblCurrentSimulationMinutes.IsHandleCreated)
			{
				frm.lblCurrentSimulationMinutes.BeginInvoke(new Action(() => frm.lblCurrentSimulationMinutes.Text = minuteCount.ToString()));
			}

			//advance timer for all boxes in warehouse
			allBoxes.Where(b => b.Status != BoxStatus.Shipped).ToList().ForEach(b => b.AddMinutes());

			//move boxes that are processing complete to the scanning queue
			allBoxes.Where(b => b.Status == BoxStatus.Processing && b.ProcessPercentComplete >= 100).ToList().ForEach(b =>
			{
				b.Status = BoxStatus.ProcessingComplete;
				b.Operator.ProcessedBoxes.Add(b);
				b.Operator.IsBusy = false;
				scanningQueue.Enqueue(b);

				if (b.Operator.ListViewItem.ListView.IsHandleCreated)
				{
					b.Operator.ListViewItem.ListView.BeginInvoke(new Action(() =>
					{
						//operator stats
						b.Operator.ListViewItem.SubItems[1].Text = b.Operator.ProcessedBoxes.Average(ba => ba.MaximumProcessMinutes).ToString("0.00");
						b.Operator.ListViewItem.SubItems[2].Text = b.Operator.ProcessedBoxes.Min(ba => ba.MaximumProcessMinutes).ToString();
						b.Operator.ListViewItem.SubItems[3].Text = b.Operator.ProcessedBoxes.Max(ba => ba.MaximumProcessMinutes).ToString();
						b.Operator.ListViewItem.SubItems[4].Text = b.Operator.ProcessedBoxes.Count().ToString();
					}));
				}
			});

			//add new box for each available operator
			operators.Where(o => !o.IsBusy).ToList().ForEach(o =>
			{
				var newBoxProcessingTime = rnd.Next(minimumProcessingMinutes, maximumProcessingMinutes);
				var newBoxScanningTime = rnd.Next(minimumScanningMinutes, maximumScanningMinutes);
				var newBox = new Box(newBoxProcessingTime, newBoxScanningTime)
				{
					Operator = o,
					Status = BoxStatus.Processing
				};
				newBox.Operator.IsBusy = true;
				allBoxes.Add(newBox);
			});

			//move boxes that are scanning complete to the loading queue
			allBoxes.Where(b => b.Status == BoxStatus.Scanning && b.ScanningPercentComplete >= 100).ToList().ForEach(b =>
			{
				b.Status = BoxStatus.ScanningComplete;
				b.Scanner.ScannedBoxes.Add(b);
				b.Scanner.IsBusy = false;
				loadingQueue.Enqueue(b);

				if (b.Scanner.ListViewItem.ListView.IsHandleCreated)
				{
					b.Scanner.ListViewItem.ListView.BeginInvoke(new Action(() =>
					{
						//scanner stats
						b.Scanner.ListViewItem.SubItems[1].Text = b.Scanner.ScannedBoxes.Average(ba => ba.MaximumScanningMinutes).ToString("0.00");
						b.Scanner.ListViewItem.SubItems[2].Text = b.Scanner.ScannedBoxes.Min(ba => ba.MaximumScanningMinutes).ToString();
						b.Scanner.ListViewItem.SubItems[3].Text = b.Scanner.ScannedBoxes.Max(ba => ba.MaximumScanningMinutes).ToString();
						b.Scanner.ListViewItem.SubItems[4].Text = b.Scanner.ScannedBoxes.Count().ToString();
					}));
				}
			});

			//get box from scanning queue for each available scanner
			if (scanningQueue.Count > 0)
			{
				scanners.Where(s => !s.IsBusy).ToList().ForEach(s =>
				{
					var boxToScan = scanningQueue.Dequeue();
					boxToScan.Status = BoxStatus.Scanning;
					boxToScan.Scanner = s;
					boxToScan.Scanner.IsBusy = true;
				});
			}

			//get box from loading queue while a truck is available
			for (var li = loadingQueue.Count - 1; li >= 0; li--)
			{
				var truckToLoad = trucks.First(t => !t.IsShipped && t.LoadedBoxes.Count < boxCountPerTruck);
				if (truckToLoad != null)
				{
					var boxToLoad = loadingQueue.Dequeue();
					if (boxToLoad != null)
					{
						truckToLoad.LoadedBoxes.Add(boxToLoad);
						boxToLoad.Status = BoxStatus.Loaded;
					}
					else
					{
						break;
					}
				}
				else
				{
					break;
				}
			}

			//ship full trucks
			trucks.Where(t => !t.IsShipped && t.LoadedBoxes.Count >= boxCountPerTruck).ToList().ForEach(t =>
			{
				t.Ship();
				if (t.ListViewItem.ListView.IsHandleCreated)
				{
					t.ListViewItem.ListView.BeginInvoke(new Action(() =>
					{
						//truck stats
						t.ListViewItem.SubItems[1].Text = t.LoadedBoxes.Average(ba => ba.MinutesAwaitingShipping).ToString("0.00");
						t.ListViewItem.SubItems[2].Text = t.LoadedBoxes.Min(ba => ba.MinutesAwaitingShipping).ToString();
						t.ListViewItem.SubItems[3].Text = t.LoadedBoxes.Max(ba => ba.MinutesAwaitingShipping).ToString();
						t.ListViewItem.SubItems[4].Text = "true";
					}));
				}
			});

			//add new truck at specified interval
			if (minuteCount % newTruckInterval == 0)
			{
				var newTruck = new Truck();
				trucks.Add(newTruck);
				var lit = new ListViewItem(new[] { newTruck.TruckId.ToString(), "0", "0", "0", "false" })
				{
					Tag = newTruck
				};
				if (frm.lvwTruckStatistics.IsHandleCreated)
				{
					frm.lvwTruckStatistics.BeginInvoke(new Action(() => frm.lvwTruckStatistics.Items.Add(lit)));
					newTruck.ListViewItem = lit;
				}
			}

			//overall stats
			if (allBoxes.Count(ba => ba.Status == BoxStatus.Shipped) > 0)
			{
				if (frm.lvwOverallStatistics.IsHandleCreated)
				{
					frm.lvwOverallStatistics.BeginInvoke(new Action(() =>
					{
						frm.lvwOverallStatistics.Items[0].SubItems[0].Text = allBoxes.Where(ba => ba.Status == BoxStatus.Shipped).Average(ba => ba.TotalMinutes).ToString("0.00");
						frm.lvwOverallStatistics.Items[0].SubItems[1].Text = allBoxes.Where(ba => ba.Status == BoxStatus.Shipped).Min(ba => ba.TotalMinutes).ToString();
						frm.lvwOverallStatistics.Items[0].SubItems[2].Text = allBoxes.Where(ba => ba.Status == BoxStatus.Shipped).Max(ba => ba.TotalMinutes).ToString();
					}));
				}
			}

			sw.Stop();
			totalTicks += sw.ElapsedTicks;
			if (frm.lblTimePerSimulationMinuteValue.IsHandleCreated)
			{
				frm.lblTimePerSimulationMinuteValue.BeginInvoke(new Action(() => frm.lblTimePerSimulationMinuteValue.Text = sw.ElapsedTicks.ToString() + " - " + ((decimal)totalTicks / minuteCount).ToString("0.00")));
			}

			if (minuteCount >= simulationMinutesTotal)
			{
				frm.sim = null;
				return;
			}
			tmr.Start();
		}
	}
}