using System;

namespace ProcessSimulation
{
	public class Box
	{
		public Box(int _maximumProcessMinutes, int _maximumScanningMinutes)
		{
			BoxId = Guid.NewGuid();
			Status = BoxStatus.New;
			Operator = null;
			MaximumProcessMinutes = _maximumProcessMinutes;
			CurrentProcessMinutes = 0;
			Scanner = null;
			MaximumScanningMinutes = _maximumScanningMinutes;
			CurrentScanningMinutes = 0;
			MinutesAwaitingShipping = 0;
			TotalMinutes = 0;
		}

		public Guid BoxId
		{
			get;
			private set;
		}

		public BoxStatus Status
		{
			get;
			set;
		}

		public Operator Operator
		{
			get;
			set;
		}

		public int MaximumProcessMinutes
		{
			get;
		}

		public int CurrentProcessMinutes
		{
			get;
			private set;
		}

		public int ProcessPercentComplete
		{
			get
			{
				return CurrentProcessMinutes / MaximumProcessMinutes * 100;
			}
		}

		public Scanner Scanner
		{
			get;
			set;
		}

		public int MaximumScanningMinutes
		{
			get;
		}

		public int CurrentScanningMinutes
		{
			get;
			private set;
		}

		public int ScanningPercentComplete
		{
			get
			{
				return CurrentScanningMinutes / MaximumScanningMinutes * 100;
			}
		}

		public int MinutesAwaitingShipping
		{
			get;
			private set;
		}

		public int TotalMinutes
		{
			get;
			private set;
		}

		public void AddMinutes(int minutesToAdd = 1)
		{
			if (Status == BoxStatus.Processing)
			{
				CurrentProcessMinutes += minutesToAdd;
			}
			else if (Status == BoxStatus.Scanning)
			{
				CurrentScanningMinutes += minutesToAdd;
			}
			else if (Status == BoxStatus.ScanningComplete || Status == BoxStatus.Loaded)
			{
				MinutesAwaitingShipping += minutesToAdd;
			}
			if (Status != BoxStatus.Shipped)
			{
				TotalMinutes += minutesToAdd;
			}
		}
	}
}