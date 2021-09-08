namespace ProcessSimulation
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblOperatorCount = new System.Windows.Forms.Label();
			this.nudOperatorCount = new System.Windows.Forms.NumericUpDown();
			this.lblScannerCount = new System.Windows.Forms.Label();
			this.nudScannerCount = new System.Windows.Forms.NumericUpDown();
			this.nudMaximumProcessingMinutes = new System.Windows.Forms.NumericUpDown();
			this.lblMaximumProcessingMinutes = new System.Windows.Forms.Label();
			this.nudMinimumProcessingMinutes = new System.Windows.Forms.NumericUpDown();
			this.lblMinimumProcessingMinutes = new System.Windows.Forms.Label();
			this.nudMaximumScanningMinutes = new System.Windows.Forms.NumericUpDown();
			this.lblMaximumScanningMinutes = new System.Windows.Forms.Label();
			this.nudMinimumScanningMinutes = new System.Windows.Forms.NumericUpDown();
			this.lblMinimumScanningMinutes = new System.Windows.Forms.Label();
			this.lblMinutes0 = new System.Windows.Forms.Label();
			this.lblMinutes1 = new System.Windows.Forms.Label();
			this.lblMinutes2 = new System.Windows.Forms.Label();
			this.lblMinutes3 = new System.Windows.Forms.Label();
			this.lblMinutes4 = new System.Windows.Forms.Label();
			this.lblBoxes0 = new System.Windows.Forms.Label();
			this.nudNewTruckInterval = new System.Windows.Forms.NumericUpDown();
			this.lblNewTruckInterval = new System.Windows.Forms.Label();
			this.nudBoxCountPerTruck = new System.Windows.Forms.NumericUpDown();
			this.lblBoxCountPerTruck = new System.Windows.Forms.Label();
			this.lblMinutes5 = new System.Windows.Forms.Label();
			this.lblMilliseconds0 = new System.Windows.Forms.Label();
			this.nudSimulationMinutesTotal = new System.Windows.Forms.NumericUpDown();
			this.lblSimulationMinutesTotal = new System.Windows.Forms.Label();
			this.nudMillisecondsPerSimulatedMinute = new System.Windows.Forms.NumericUpDown();
			this.lblMillisecondsPerSimulatedMinute = new System.Windows.Forms.Label();
			this.btnStartSimulation = new System.Windows.Forms.Button();
			this.lblCurrentSimulationMinute = new System.Windows.Forms.Label();
			this.lblOperators0 = new System.Windows.Forms.Label();
			this.lblScanners0 = new System.Windows.Forms.Label();
			this.lblCurrentSimulationMinutes = new System.Windows.Forms.Label();
			this.lblOperatorStatistics = new System.Windows.Forms.Label();
			this.lvwOperatorStatistics = new System.Windows.Forms.ListView();
			this.colOperatorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOperatorAverageBoxesPerHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOperatorMinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOperatorMaxTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOperatorTotalBoxes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvwScannerStatistics = new System.Windows.Forms.ListView();
			this.colScannerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colScannerAverageBoxesPerHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colScannerMinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colScannerMaxTimme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colScannerTotalBoxes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblScannerStatistics = new System.Windows.Forms.Label();
			this.lvwTruckStatistics = new System.Windows.Forms.ListView();
			this.colTruckId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTruckAverageWaitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTruckMinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTruckMaxTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblTruckStatistics = new System.Windows.Forms.Label();
			this.lvwOverallStatistics = new System.Windows.Forms.ListView();
			this.colOverallAvgTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOverallMinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOverallMaxTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblOverallStatistics = new System.Windows.Forms.Label();
			this.colTruckShipped = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblTimePerSimulationMinuteValue = new System.Windows.Forms.Label();
			this.lblTimePerSimulationMinute = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudOperatorCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudScannerCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximumProcessingMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimumProcessingMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximumScanningMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimumScanningMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNewTruckInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBoxCountPerTruck)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSimulationMinutesTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMillisecondsPerSimulatedMinute)).BeginInit();
			this.SuspendLayout();
			// 
			// lblOperatorCount
			// 
			this.lblOperatorCount.AutoSize = true;
			this.lblOperatorCount.Location = new System.Drawing.Point(12, 9);
			this.lblOperatorCount.Name = "lblOperatorCount";
			this.lblOperatorCount.Size = new System.Drawing.Size(119, 21);
			this.lblOperatorCount.TabIndex = 0;
			this.lblOperatorCount.Text = "Operator Count";
			// 
			// nudOperatorCount
			// 
			this.nudOperatorCount.Location = new System.Drawing.Point(16, 33);
			this.nudOperatorCount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudOperatorCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudOperatorCount.Name = "nudOperatorCount";
			this.nudOperatorCount.Size = new System.Drawing.Size(120, 29);
			this.nudOperatorCount.TabIndex = 1;
			this.nudOperatorCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lblScannerCount
			// 
			this.lblScannerCount.AutoSize = true;
			this.lblScannerCount.Location = new System.Drawing.Point(232, 9);
			this.lblScannerCount.Name = "lblScannerCount";
			this.lblScannerCount.Size = new System.Drawing.Size(112, 21);
			this.lblScannerCount.TabIndex = 3;
			this.lblScannerCount.Text = "Scanner Count";
			// 
			// nudScannerCount
			// 
			this.nudScannerCount.Location = new System.Drawing.Point(236, 33);
			this.nudScannerCount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudScannerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudScannerCount.Name = "nudScannerCount";
			this.nudScannerCount.Size = new System.Drawing.Size(120, 29);
			this.nudScannerCount.TabIndex = 4;
			this.nudScannerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudMaximumProcessingMinutes
			// 
			this.nudMaximumProcessingMinutes.Location = new System.Drawing.Point(236, 148);
			this.nudMaximumProcessingMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.nudMaximumProcessingMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMaximumProcessingMinutes.Name = "nudMaximumProcessingMinutes";
			this.nudMaximumProcessingMinutes.Size = new System.Drawing.Size(120, 29);
			this.nudMaximumProcessingMinutes.TabIndex = 10;
			this.nudMaximumProcessingMinutes.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// lblMaximumProcessingMinutes
			// 
			this.lblMaximumProcessingMinutes.AutoSize = true;
			this.lblMaximumProcessingMinutes.Location = new System.Drawing.Point(232, 100);
			this.lblMaximumProcessingMinutes.Name = "lblMaximumProcessingMinutes";
			this.lblMaximumProcessingMinutes.Size = new System.Drawing.Size(145, 42);
			this.lblMaximumProcessingMinutes.TabIndex = 9;
			this.lblMaximumProcessingMinutes.Text = "Maximum\r\nProcessing Minutes";
			// 
			// nudMinimumProcessingMinutes
			// 
			this.nudMinimumProcessingMinutes.Location = new System.Drawing.Point(16, 148);
			this.nudMinimumProcessingMinutes.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.nudMinimumProcessingMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMinimumProcessingMinutes.Name = "nudMinimumProcessingMinutes";
			this.nudMinimumProcessingMinutes.Size = new System.Drawing.Size(120, 29);
			this.nudMinimumProcessingMinutes.TabIndex = 7;
			this.nudMinimumProcessingMinutes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// lblMinimumProcessingMinutes
			// 
			this.lblMinimumProcessingMinutes.AutoSize = true;
			this.lblMinimumProcessingMinutes.Location = new System.Drawing.Point(12, 100);
			this.lblMinimumProcessingMinutes.Name = "lblMinimumProcessingMinutes";
			this.lblMinimumProcessingMinutes.Size = new System.Drawing.Size(145, 42);
			this.lblMinimumProcessingMinutes.TabIndex = 6;
			this.lblMinimumProcessingMinutes.Text = "Minimum\r\nProcessing Minutes";
			// 
			// nudMaximumScanningMinutes
			// 
			this.nudMaximumScanningMinutes.Location = new System.Drawing.Point(236, 263);
			this.nudMaximumScanningMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.nudMaximumScanningMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMaximumScanningMinutes.Name = "nudMaximumScanningMinutes";
			this.nudMaximumScanningMinutes.Size = new System.Drawing.Size(120, 29);
			this.nudMaximumScanningMinutes.TabIndex = 16;
			this.nudMaximumScanningMinutes.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// lblMaximumScanningMinutes
			// 
			this.lblMaximumScanningMinutes.AutoSize = true;
			this.lblMaximumScanningMinutes.Location = new System.Drawing.Point(232, 215);
			this.lblMaximumScanningMinutes.Name = "lblMaximumScanningMinutes";
			this.lblMaximumScanningMinutes.Size = new System.Drawing.Size(134, 42);
			this.lblMaximumScanningMinutes.TabIndex = 15;
			this.lblMaximumScanningMinutes.Text = "Maximum\r\nScanning Minutes";
			// 
			// nudMinimumScanningMinutes
			// 
			this.nudMinimumScanningMinutes.Location = new System.Drawing.Point(16, 263);
			this.nudMinimumScanningMinutes.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.nudMinimumScanningMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMinimumScanningMinutes.Name = "nudMinimumScanningMinutes";
			this.nudMinimumScanningMinutes.Size = new System.Drawing.Size(120, 29);
			this.nudMinimumScanningMinutes.TabIndex = 13;
			this.nudMinimumScanningMinutes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// lblMinimumScanningMinutes
			// 
			this.lblMinimumScanningMinutes.AutoSize = true;
			this.lblMinimumScanningMinutes.Location = new System.Drawing.Point(12, 215);
			this.lblMinimumScanningMinutes.Name = "lblMinimumScanningMinutes";
			this.lblMinimumScanningMinutes.Size = new System.Drawing.Size(134, 42);
			this.lblMinimumScanningMinutes.TabIndex = 12;
			this.lblMinimumScanningMinutes.Text = "Minimum\r\nScanning Minutes";
			// 
			// lblMinutes0
			// 
			this.lblMinutes0.AutoSize = true;
			this.lblMinutes0.Location = new System.Drawing.Point(142, 150);
			this.lblMinutes0.Name = "lblMinutes0";
			this.lblMinutes0.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes0.TabIndex = 8;
			this.lblMinutes0.Text = "minutes";
			// 
			// lblMinutes1
			// 
			this.lblMinutes1.AutoSize = true;
			this.lblMinutes1.Location = new System.Drawing.Point(362, 150);
			this.lblMinutes1.Name = "lblMinutes1";
			this.lblMinutes1.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes1.TabIndex = 11;
			this.lblMinutes1.Text = "minutes";
			// 
			// lblMinutes2
			// 
			this.lblMinutes2.AutoSize = true;
			this.lblMinutes2.Location = new System.Drawing.Point(142, 265);
			this.lblMinutes2.Name = "lblMinutes2";
			this.lblMinutes2.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes2.TabIndex = 14;
			this.lblMinutes2.Text = "minutes";
			// 
			// lblMinutes3
			// 
			this.lblMinutes3.AutoSize = true;
			this.lblMinutes3.Location = new System.Drawing.Point(362, 265);
			this.lblMinutes3.Name = "lblMinutes3";
			this.lblMinutes3.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes3.TabIndex = 17;
			this.lblMinutes3.Text = "minutes";
			// 
			// lblMinutes4
			// 
			this.lblMinutes4.AutoSize = true;
			this.lblMinutes4.Location = new System.Drawing.Point(362, 380);
			this.lblMinutes4.Name = "lblMinutes4";
			this.lblMinutes4.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes4.TabIndex = 23;
			this.lblMinutes4.Text = "minutes";
			// 
			// lblBoxes0
			// 
			this.lblBoxes0.AutoSize = true;
			this.lblBoxes0.Location = new System.Drawing.Point(142, 380);
			this.lblBoxes0.Name = "lblBoxes0";
			this.lblBoxes0.Size = new System.Drawing.Size(50, 21);
			this.lblBoxes0.TabIndex = 20;
			this.lblBoxes0.Text = "boxes";
			// 
			// nudNewTruckInterval
			// 
			this.nudNewTruckInterval.Location = new System.Drawing.Point(236, 378);
			this.nudNewTruckInterval.Maximum = new decimal(new int[] {
            2880,
            0,
            0,
            0});
			this.nudNewTruckInterval.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
			this.nudNewTruckInterval.Name = "nudNewTruckInterval";
			this.nudNewTruckInterval.Size = new System.Drawing.Size(120, 29);
			this.nudNewTruckInterval.TabIndex = 22;
			this.nudNewTruckInterval.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
			// 
			// lblNewTruckInterval
			// 
			this.lblNewTruckInterval.AutoSize = true;
			this.lblNewTruckInterval.Location = new System.Drawing.Point(232, 330);
			this.lblNewTruckInterval.Name = "lblNewTruckInterval";
			this.lblNewTruckInterval.Size = new System.Drawing.Size(83, 42);
			this.lblNewTruckInterval.TabIndex = 21;
			this.lblNewTruckInterval.Text = "New Truck\r\nInterval";
			// 
			// nudBoxCountPerTruck
			// 
			this.nudBoxCountPerTruck.Location = new System.Drawing.Point(16, 378);
			this.nudBoxCountPerTruck.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.nudBoxCountPerTruck.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudBoxCountPerTruck.Name = "nudBoxCountPerTruck";
			this.nudBoxCountPerTruck.Size = new System.Drawing.Size(120, 29);
			this.nudBoxCountPerTruck.TabIndex = 19;
			this.nudBoxCountPerTruck.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
			// 
			// lblBoxCountPerTruck
			// 
			this.lblBoxCountPerTruck.AutoSize = true;
			this.lblBoxCountPerTruck.Location = new System.Drawing.Point(12, 330);
			this.lblBoxCountPerTruck.Name = "lblBoxCountPerTruck";
			this.lblBoxCountPerTruck.Size = new System.Drawing.Size(81, 42);
			this.lblBoxCountPerTruck.TabIndex = 18;
			this.lblBoxCountPerTruck.Text = "Box Count\r\nPer Truck";
			// 
			// lblMinutes5
			// 
			this.lblMinutes5.AutoSize = true;
			this.lblMinutes5.Location = new System.Drawing.Point(362, 495);
			this.lblMinutes5.Name = "lblMinutes5";
			this.lblMinutes5.Size = new System.Drawing.Size(66, 21);
			this.lblMinutes5.TabIndex = 29;
			this.lblMinutes5.Text = "minutes";
			// 
			// lblMilliseconds0
			// 
			this.lblMilliseconds0.AutoSize = true;
			this.lblMilliseconds0.Location = new System.Drawing.Point(142, 495);
			this.lblMilliseconds0.Name = "lblMilliseconds0";
			this.lblMilliseconds0.Size = new System.Drawing.Size(96, 21);
			this.lblMilliseconds0.TabIndex = 26;
			this.lblMilliseconds0.Text = "milliseconds";
			// 
			// nudSimulationMinutesTotal
			// 
			this.nudSimulationMinutesTotal.Location = new System.Drawing.Point(236, 493);
			this.nudSimulationMinutesTotal.Maximum = new decimal(new int[] {
            43200,
            0,
            0,
            0});
			this.nudSimulationMinutesTotal.Minimum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
			this.nudSimulationMinutesTotal.Name = "nudSimulationMinutesTotal";
			this.nudSimulationMinutesTotal.Size = new System.Drawing.Size(120, 29);
			this.nudSimulationMinutesTotal.TabIndex = 28;
			this.nudSimulationMinutesTotal.Value = new decimal(new int[] {
            14400,
            0,
            0,
            0});
			// 
			// lblSimulationMinutesTotal
			// 
			this.lblSimulationMinutesTotal.AutoSize = true;
			this.lblSimulationMinutesTotal.Location = new System.Drawing.Point(232, 445);
			this.lblSimulationMinutesTotal.Name = "lblSimulationMinutesTotal";
			this.lblSimulationMinutesTotal.Size = new System.Drawing.Size(102, 42);
			this.lblSimulationMinutesTotal.TabIndex = 27;
			this.lblSimulationMinutesTotal.Text = "Simulation\r\nMinutes Total";
			// 
			// nudMillisecondsPerSimulatedMinute
			// 
			this.nudMillisecondsPerSimulatedMinute.Location = new System.Drawing.Point(16, 493);
			this.nudMillisecondsPerSimulatedMinute.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.nudMillisecondsPerSimulatedMinute.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMillisecondsPerSimulatedMinute.Name = "nudMillisecondsPerSimulatedMinute";
			this.nudMillisecondsPerSimulatedMinute.Size = new System.Drawing.Size(120, 29);
			this.nudMillisecondsPerSimulatedMinute.TabIndex = 25;
			this.nudMillisecondsPerSimulatedMinute.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// lblMillisecondsPerSimulatedMinute
			// 
			this.lblMillisecondsPerSimulatedMinute.AutoSize = true;
			this.lblMillisecondsPerSimulatedMinute.Location = new System.Drawing.Point(12, 445);
			this.lblMillisecondsPerSimulatedMinute.Name = "lblMillisecondsPerSimulatedMinute";
			this.lblMillisecondsPerSimulatedMinute.Size = new System.Drawing.Size(133, 42);
			this.lblMillisecondsPerSimulatedMinute.TabIndex = 24;
			this.lblMillisecondsPerSimulatedMinute.Text = "Milliseconds Per\r\nSimulated Minute";
			// 
			// btnStartSimulation
			// 
			this.btnStartSimulation.Location = new System.Drawing.Point(12, 576);
			this.btnStartSimulation.Name = "btnStartSimulation";
			this.btnStartSimulation.Size = new System.Drawing.Size(128, 48);
			this.btnStartSimulation.TabIndex = 30;
			this.btnStartSimulation.Text = "Start\r\nSimulation";
			this.btnStartSimulation.UseVisualStyleBackColor = true;
			this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
			// 
			// lblCurrentSimulationMinute
			// 
			this.lblCurrentSimulationMinute.AutoSize = true;
			this.lblCurrentSimulationMinute.Location = new System.Drawing.Point(570, 9);
			this.lblCurrentSimulationMinute.Name = "lblCurrentSimulationMinute";
			this.lblCurrentSimulationMinute.Size = new System.Drawing.Size(195, 21);
			this.lblCurrentSimulationMinute.TabIndex = 31;
			this.lblCurrentSimulationMinute.Text = "Current Simulation Minute";
			// 
			// lblOperators0
			// 
			this.lblOperators0.AutoSize = true;
			this.lblOperators0.Location = new System.Drawing.Point(142, 35);
			this.lblOperators0.Name = "lblOperators0";
			this.lblOperators0.Size = new System.Drawing.Size(77, 21);
			this.lblOperators0.TabIndex = 2;
			this.lblOperators0.Text = "operators";
			// 
			// lblScanners0
			// 
			this.lblScanners0.AutoSize = true;
			this.lblScanners0.Location = new System.Drawing.Point(362, 35);
			this.lblScanners0.Name = "lblScanners0";
			this.lblScanners0.Size = new System.Drawing.Size(71, 21);
			this.lblScanners0.TabIndex = 5;
			this.lblScanners0.Text = "scanners";
			// 
			// lblCurrentSimulationMinutes
			// 
			this.lblCurrentSimulationMinutes.AutoSize = true;
			this.lblCurrentSimulationMinutes.Location = new System.Drawing.Point(574, 34);
			this.lblCurrentSimulationMinutes.Name = "lblCurrentSimulationMinutes";
			this.lblCurrentSimulationMinutes.Size = new System.Drawing.Size(19, 21);
			this.lblCurrentSimulationMinutes.TabIndex = 32;
			this.lblCurrentSimulationMinutes.Text = "0";
			// 
			// lblOperatorStatistics
			// 
			this.lblOperatorStatistics.AutoSize = true;
			this.lblOperatorStatistics.Location = new System.Drawing.Point(570, 100);
			this.lblOperatorStatistics.Name = "lblOperatorStatistics";
			this.lblOperatorStatistics.Size = new System.Drawing.Size(137, 21);
			this.lblOperatorStatistics.TabIndex = 33;
			this.lblOperatorStatistics.Text = "Operator Statistics";
			// 
			// lvwOperatorStatistics
			// 
			this.lvwOperatorStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOperatorId,
            this.colOperatorAverageBoxesPerHour,
            this.colOperatorMinTime,
            this.colOperatorMaxTime,
            this.colOperatorTotalBoxes});
			this.lvwOperatorStatistics.FullRowSelect = true;
			this.lvwOperatorStatistics.HideSelection = false;
			this.lvwOperatorStatistics.Location = new System.Drawing.Point(578, 124);
			this.lvwOperatorStatistics.MultiSelect = false;
			this.lvwOperatorStatistics.Name = "lvwOperatorStatistics";
			this.lvwOperatorStatistics.Size = new System.Drawing.Size(557, 97);
			this.lvwOperatorStatistics.TabIndex = 34;
			this.lvwOperatorStatistics.UseCompatibleStateImageBehavior = false;
			this.lvwOperatorStatistics.View = System.Windows.Forms.View.Details;
			// 
			// colOperatorId
			// 
			this.colOperatorId.Text = "Operator Id";
			this.colOperatorId.Width = 100;
			// 
			// colOperatorAverageBoxesPerHour
			// 
			this.colOperatorAverageBoxesPerHour.Text = "Avg Boxes Per Hour";
			this.colOperatorAverageBoxesPerHour.Width = 100;
			// 
			// colOperatorMinTime
			// 
			this.colOperatorMinTime.Text = "Min Time";
			this.colOperatorMinTime.Width = 100;
			// 
			// colOperatorMaxTime
			// 
			this.colOperatorMaxTime.Text = "Max Time";
			this.colOperatorMaxTime.Width = 100;
			// 
			// colOperatorTotalBoxes
			// 
			this.colOperatorTotalBoxes.Text = "Total Boxes";
			this.colOperatorTotalBoxes.Width = 100;
			// 
			// lvwScannerStatistics
			// 
			this.lvwScannerStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colScannerId,
            this.colScannerAverageBoxesPerHour,
            this.colScannerMinTime,
            this.colScannerMaxTimme,
            this.colScannerTotalBoxes});
			this.lvwScannerStatistics.FullRowSelect = true;
			this.lvwScannerStatistics.HideSelection = false;
			this.lvwScannerStatistics.Location = new System.Drawing.Point(578, 260);
			this.lvwScannerStatistics.MultiSelect = false;
			this.lvwScannerStatistics.Name = "lvwScannerStatistics";
			this.lvwScannerStatistics.Size = new System.Drawing.Size(557, 97);
			this.lvwScannerStatistics.TabIndex = 36;
			this.lvwScannerStatistics.UseCompatibleStateImageBehavior = false;
			this.lvwScannerStatistics.View = System.Windows.Forms.View.Details;
			// 
			// colScannerId
			// 
			this.colScannerId.Text = "Scanner Id";
			this.colScannerId.Width = 100;
			// 
			// colScannerAverageBoxesPerHour
			// 
			this.colScannerAverageBoxesPerHour.Text = "Avg Boxes Per Hour";
			this.colScannerAverageBoxesPerHour.Width = 100;
			// 
			// colScannerMinTime
			// 
			this.colScannerMinTime.Text = "Min Time";
			this.colScannerMinTime.Width = 100;
			// 
			// colScannerMaxTimme
			// 
			this.colScannerMaxTimme.Text = "Max Time";
			this.colScannerMaxTimme.Width = 100;
			// 
			// colScannerTotalBoxes
			// 
			this.colScannerTotalBoxes.Text = "Total Boxes";
			this.colScannerTotalBoxes.Width = 100;
			// 
			// lblScannerStatistics
			// 
			this.lblScannerStatistics.AutoSize = true;
			this.lblScannerStatistics.Location = new System.Drawing.Point(570, 236);
			this.lblScannerStatistics.Name = "lblScannerStatistics";
			this.lblScannerStatistics.Size = new System.Drawing.Size(130, 21);
			this.lblScannerStatistics.TabIndex = 35;
			this.lblScannerStatistics.Text = "Scanner Statistics";
			// 
			// lvwTruckStatistics
			// 
			this.lvwTruckStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTruckId,
            this.colTruckAverageWaitTime,
            this.colTruckMinTime,
            this.colTruckMaxTime,
            this.colTruckShipped});
			this.lvwTruckStatistics.FullRowSelect = true;
			this.lvwTruckStatistics.HideSelection = false;
			this.lvwTruckStatistics.Location = new System.Drawing.Point(578, 396);
			this.lvwTruckStatistics.MultiSelect = false;
			this.lvwTruckStatistics.Name = "lvwTruckStatistics";
			this.lvwTruckStatistics.Size = new System.Drawing.Size(557, 97);
			this.lvwTruckStatistics.TabIndex = 38;
			this.lvwTruckStatistics.UseCompatibleStateImageBehavior = false;
			this.lvwTruckStatistics.View = System.Windows.Forms.View.Details;
			// 
			// colTruckId
			// 
			this.colTruckId.Text = "Truck Id";
			this.colTruckId.Width = 100;
			// 
			// colTruckAverageWaitTime
			// 
			this.colTruckAverageWaitTime.Text = "Avg Wait Time";
			this.colTruckAverageWaitTime.Width = 100;
			// 
			// colTruckMinTime
			// 
			this.colTruckMinTime.Text = "Min Time";
			this.colTruckMinTime.Width = 100;
			// 
			// colTruckMaxTime
			// 
			this.colTruckMaxTime.Text = "Max Time";
			this.colTruckMaxTime.Width = 100;
			// 
			// lblTruckStatistics
			// 
			this.lblTruckStatistics.AutoSize = true;
			this.lblTruckStatistics.Location = new System.Drawing.Point(570, 372);
			this.lblTruckStatistics.Name = "lblTruckStatistics";
			this.lblTruckStatistics.Size = new System.Drawing.Size(111, 21);
			this.lblTruckStatistics.TabIndex = 37;
			this.lblTruckStatistics.Text = "Truck Statistics";
			// 
			// lvwOverallStatistics
			// 
			this.lvwOverallStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOverallAvgTime,
            this.colOverallMinTime,
            this.colOverallMaxTime});
			this.lvwOverallStatistics.FullRowSelect = true;
			this.lvwOverallStatistics.HideSelection = false;
			this.lvwOverallStatistics.Location = new System.Drawing.Point(578, 532);
			this.lvwOverallStatistics.MultiSelect = false;
			this.lvwOverallStatistics.Name = "lvwOverallStatistics";
			this.lvwOverallStatistics.Size = new System.Drawing.Size(557, 97);
			this.lvwOverallStatistics.TabIndex = 40;
			this.lvwOverallStatistics.UseCompatibleStateImageBehavior = false;
			this.lvwOverallStatistics.View = System.Windows.Forms.View.Details;
			// 
			// colOverallAvgTime
			// 
			this.colOverallAvgTime.Text = "Avg Time";
			this.colOverallAvgTime.Width = 100;
			// 
			// colOverallMinTime
			// 
			this.colOverallMinTime.Text = "Min Time";
			this.colOverallMinTime.Width = 100;
			// 
			// colOverallMaxTime
			// 
			this.colOverallMaxTime.Text = "Max Time";
			this.colOverallMaxTime.Width = 100;
			// 
			// lblOverallStatistics
			// 
			this.lblOverallStatistics.AutoSize = true;
			this.lblOverallStatistics.Location = new System.Drawing.Point(570, 508);
			this.lblOverallStatistics.Name = "lblOverallStatistics";
			this.lblOverallStatistics.Size = new System.Drawing.Size(124, 21);
			this.lblOverallStatistics.TabIndex = 39;
			this.lblOverallStatistics.Text = "Overall Statistics";
			// 
			// colTruckShipped
			// 
			this.colTruckShipped.Text = "Shipped";
			this.colTruckShipped.Width = 100;
			// 
			// lblTimePerSimulationMinuteValue
			// 
			this.lblTimePerSimulationMinuteValue.AutoSize = true;
			this.lblTimePerSimulationMinuteValue.Location = new System.Drawing.Point(884, 34);
			this.lblTimePerSimulationMinuteValue.Name = "lblTimePerSimulationMinuteValue";
			this.lblTimePerSimulationMinuteValue.Size = new System.Drawing.Size(63, 21);
			this.lblTimePerSimulationMinuteValue.TabIndex = 42;
			this.lblTimePerSimulationMinuteValue.Text = "0 - 0.00";
			// 
			// lblTimePerSimulationMinute
			// 
			this.lblTimePerSimulationMinute.AutoSize = true;
			this.lblTimePerSimulationMinute.Location = new System.Drawing.Point(880, 9);
			this.lblTimePerSimulationMinute.Name = "lblTimePerSimulationMinute";
			this.lblTimePerSimulationMinute.Size = new System.Drawing.Size(270, 21);
			this.lblTimePerSimulationMinute.TabIndex = 41;
			this.lblTimePerSimulationMinute.Text = "Time Per Sim. Minute (ticks, cur - avg)";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 645);
			this.Controls.Add(this.lblTimePerSimulationMinuteValue);
			this.Controls.Add(this.lblTimePerSimulationMinute);
			this.Controls.Add(this.lvwOverallStatistics);
			this.Controls.Add(this.lblOverallStatistics);
			this.Controls.Add(this.lvwTruckStatistics);
			this.Controls.Add(this.lblTruckStatistics);
			this.Controls.Add(this.lvwScannerStatistics);
			this.Controls.Add(this.lblScannerStatistics);
			this.Controls.Add(this.lvwOperatorStatistics);
			this.Controls.Add(this.lblOperatorStatistics);
			this.Controls.Add(this.lblCurrentSimulationMinutes);
			this.Controls.Add(this.lblScanners0);
			this.Controls.Add(this.lblOperators0);
			this.Controls.Add(this.lblCurrentSimulationMinute);
			this.Controls.Add(this.btnStartSimulation);
			this.Controls.Add(this.lblMinutes5);
			this.Controls.Add(this.lblMilliseconds0);
			this.Controls.Add(this.nudSimulationMinutesTotal);
			this.Controls.Add(this.lblSimulationMinutesTotal);
			this.Controls.Add(this.nudMillisecondsPerSimulatedMinute);
			this.Controls.Add(this.lblMillisecondsPerSimulatedMinute);
			this.Controls.Add(this.lblMinutes4);
			this.Controls.Add(this.lblBoxes0);
			this.Controls.Add(this.nudNewTruckInterval);
			this.Controls.Add(this.lblNewTruckInterval);
			this.Controls.Add(this.nudBoxCountPerTruck);
			this.Controls.Add(this.lblBoxCountPerTruck);
			this.Controls.Add(this.lblMinutes3);
			this.Controls.Add(this.lblMinutes2);
			this.Controls.Add(this.lblMinutes1);
			this.Controls.Add(this.lblMinutes0);
			this.Controls.Add(this.nudMaximumScanningMinutes);
			this.Controls.Add(this.lblMaximumScanningMinutes);
			this.Controls.Add(this.nudMinimumScanningMinutes);
			this.Controls.Add(this.lblMinimumScanningMinutes);
			this.Controls.Add(this.nudMaximumProcessingMinutes);
			this.Controls.Add(this.lblMaximumProcessingMinutes);
			this.Controls.Add(this.nudMinimumProcessingMinutes);
			this.Controls.Add(this.lblMinimumProcessingMinutes);
			this.Controls.Add(this.nudScannerCount);
			this.Controls.Add(this.lblScannerCount);
			this.Controls.Add(this.nudOperatorCount);
			this.Controls.Add(this.lblOperatorCount);
			this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "Processing/Scanning/Shipping Simulation";
			((System.ComponentModel.ISupportInitialize)(this.nudOperatorCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudScannerCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximumProcessingMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimumProcessingMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaximumScanningMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinimumScanningMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNewTruckInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBoxCountPerTruck)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSimulationMinutesTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMillisecondsPerSimulatedMinute)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOperatorCount;
		private System.Windows.Forms.NumericUpDown nudOperatorCount;
		private System.Windows.Forms.Label lblScannerCount;
		private System.Windows.Forms.NumericUpDown nudScannerCount;
		private System.Windows.Forms.NumericUpDown nudMaximumProcessingMinutes;
		private System.Windows.Forms.Label lblMaximumProcessingMinutes;
		private System.Windows.Forms.NumericUpDown nudMinimumProcessingMinutes;
		private System.Windows.Forms.Label lblMinimumProcessingMinutes;
		private System.Windows.Forms.NumericUpDown nudMaximumScanningMinutes;
		private System.Windows.Forms.Label lblMaximumScanningMinutes;
		private System.Windows.Forms.NumericUpDown nudMinimumScanningMinutes;
		private System.Windows.Forms.Label lblMinimumScanningMinutes;
		private System.Windows.Forms.Label lblMinutes0;
		private System.Windows.Forms.Label lblMinutes1;
		private System.Windows.Forms.Label lblMinutes2;
		private System.Windows.Forms.Label lblMinutes3;
		private System.Windows.Forms.Label lblMinutes4;
		private System.Windows.Forms.Label lblBoxes0;
		private System.Windows.Forms.NumericUpDown nudNewTruckInterval;
		private System.Windows.Forms.Label lblNewTruckInterval;
		private System.Windows.Forms.NumericUpDown nudBoxCountPerTruck;
		private System.Windows.Forms.Label lblBoxCountPerTruck;
		private System.Windows.Forms.Label lblMinutes5;
		private System.Windows.Forms.Label lblMilliseconds0;
		private System.Windows.Forms.NumericUpDown nudSimulationMinutesTotal;
		private System.Windows.Forms.Label lblSimulationMinutesTotal;
		private System.Windows.Forms.NumericUpDown nudMillisecondsPerSimulatedMinute;
		private System.Windows.Forms.Label lblMillisecondsPerSimulatedMinute;
		private System.Windows.Forms.Button btnStartSimulation;
		private System.Windows.Forms.Label lblOperators0;
		private System.Windows.Forms.Label lblScanners0;
		private System.Windows.Forms.Label lblCurrentSimulationMinute;
		public System.Windows.Forms.Label lblCurrentSimulationMinutes;
		private System.Windows.Forms.Label lblOperatorStatistics;
		public System.Windows.Forms.ListView lvwOperatorStatistics;
		private System.Windows.Forms.ColumnHeader colOperatorId;
		private System.Windows.Forms.ColumnHeader colOperatorAverageBoxesPerHour;
		private System.Windows.Forms.ColumnHeader colOperatorMinTime;
		private System.Windows.Forms.ColumnHeader colOperatorMaxTime;
		private System.Windows.Forms.ColumnHeader colOperatorTotalBoxes;
		public System.Windows.Forms.ListView lvwScannerStatistics;
		private System.Windows.Forms.ColumnHeader colScannerId;
		private System.Windows.Forms.ColumnHeader colScannerAverageBoxesPerHour;
		private System.Windows.Forms.ColumnHeader colScannerMinTime;
		private System.Windows.Forms.ColumnHeader colScannerMaxTimme;
		private System.Windows.Forms.ColumnHeader colScannerTotalBoxes;
		private System.Windows.Forms.Label lblScannerStatistics;
		public System.Windows.Forms.ListView lvwTruckStatistics;
		private System.Windows.Forms.ColumnHeader colTruckId;
		private System.Windows.Forms.ColumnHeader colTruckAverageWaitTime;
		private System.Windows.Forms.ColumnHeader colTruckMinTime;
		private System.Windows.Forms.ColumnHeader colTruckMaxTime;
		private System.Windows.Forms.Label lblTruckStatistics;
		public System.Windows.Forms.ListView lvwOverallStatistics;
		private System.Windows.Forms.ColumnHeader colOverallAvgTime;
		private System.Windows.Forms.ColumnHeader colOverallMinTime;
		private System.Windows.Forms.ColumnHeader colOverallMaxTime;
		private System.Windows.Forms.Label lblOverallStatistics;
		private System.Windows.Forms.ColumnHeader colTruckShipped;
		public System.Windows.Forms.Label lblTimePerSimulationMinuteValue;
		private System.Windows.Forms.Label lblTimePerSimulationMinute;
	}
}

