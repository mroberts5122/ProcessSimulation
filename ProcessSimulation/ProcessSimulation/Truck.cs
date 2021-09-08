using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcessSimulation
{
	public class Truck
	{
		public Truck()
		{
			TruckId = Guid.NewGuid();
			IsShipped = false;
			LoadedBoxes = new List<Box>();
		}

		public Guid TruckId
		{
			get;
			private set;
		}

		public ListViewItem ListViewItem
		{
			get;
			set;
		}

		public bool IsShipped
		{
			get;
			set;
		}

		public List<Box> LoadedBoxes
		{
			get;
			private set;
		}

		public void Ship()
		{
			LoadedBoxes.ForEach(box => box.Status = BoxStatus.Shipped);
		}
	}
}