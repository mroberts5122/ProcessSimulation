using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSimulation
{
	public partial class frmMain : Form
	{
		public Simulation sim = null;

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnStartSimulation_Click(object sender, EventArgs e)
		{
			if (sim != null)
			{
				MessageBox.Show("Simulation is already running.");
				return;
			}

			if (nudMinimumProcessingMinutes.Value > nudMaximumProcessingMinutes.Value)
			{
				MessageBox.Show("Processing maximum must be greater than or equal to minimum.");
				return;
			}
			if (nudMinimumScanningMinutes.Value > nudMaximumScanningMinutes.Value)
			{
				MessageBox.Show("Scanning maximum must be greater than or equal to minimum.");
				return;
			}


			lblCurrentSimulationMinutes.Text = "0";
			lvwOperatorStatistics.Items.Clear();
			lvwScannerStatistics.Items.Clear();
			lvwTruckStatistics.Items.Clear();
			lvwOverallStatistics.Items.Clear();
			var li = new ListViewItem(new[] { "0", "0", "0" });
			lvwOverallStatistics.Items.Add(li);

			sim = new Simulation(this, (int)nudOperatorCount.Value, (int)nudScannerCount.Value, (int)nudMinimumProcessingMinutes.Value, (int)nudMaximumProcessingMinutes.Value, (int)nudMinimumScanningMinutes.Value, (int)nudMaximumScanningMinutes.Value, (int)nudBoxCountPerTruck.Value, (int)nudNewTruckInterval.Value, (int)nudMillisecondsPerSimulatedMinute.Value, (int)nudSimulationMinutesTotal.Value);
			sim.Start();
		}
	}
}
