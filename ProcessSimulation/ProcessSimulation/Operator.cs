using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcessSimulation
{
	public class Operator
	{
		public Operator()
		{
			OperatorId = Guid.NewGuid();
			IsBusy = false;
			ProcessedBoxes = new List<Box>();
		}

		public Guid OperatorId
		{
			get;
			private set;
		}

		public ListViewItem ListViewItem
		{
			get;
			set;
		}

		public bool IsBusy
		{
			get;
			set;
		}

		public List<Box> ProcessedBoxes
		{
			get;
			private set;
		}
	}
}