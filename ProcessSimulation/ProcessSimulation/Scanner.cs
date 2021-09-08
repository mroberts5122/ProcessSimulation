using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcessSimulation
{
	public class Scanner
	{
		public Scanner()
		{
			ScannerId = Guid.NewGuid();
			IsBusy = false;
			ScannedBoxes = new List<Box>();
		}

		public Guid ScannerId
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

		public List<Box> ScannedBoxes
		{
			get;
			private set;
		}
	}
}