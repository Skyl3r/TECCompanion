namespace TEC_Companion
{
    partial class Form_MainDisplay
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.File_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aGauge2 = new AGaugeApp.AGauge();
			this.Gauge_AmbientTemp = new AGaugeApp.AGauge();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(471, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// File_Menu
			// 
			this.File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.File_Menu.Name = "File_Menu";
			this.File_Menu.Size = new System.Drawing.Size(37, 20);
			this.File_Menu.Text = "File";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// aGauge2
			// 
			this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge2.BaseArcRadius = 80;
			this.aGauge2.BaseArcStart = 135;
			this.aGauge2.BaseArcSweep = 270;
			this.aGauge2.BaseArcWidth = 2;
			this.aGauge2.Cap_Idx = ((byte)(1));
			this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
			this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
			this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
			this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
			this.aGauge2.CapText = "";
			this.aGauge2.Center = new System.Drawing.Point(100, 100);
			this.aGauge2.Location = new System.Drawing.Point(248, 41);
			this.aGauge2.MaxValue = 100F;
			this.aGauge2.MinValue = -20F;
			this.aGauge2.Name = "aGauge2";
			this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
			this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
			this.aGauge2.NeedleRadius = 80;
			this.aGauge2.NeedleType = 0;
			this.aGauge2.NeedleWidth = 5;
			this.aGauge2.Range_Idx = ((byte)(0));
			this.aGauge2.RangeColor = System.Drawing.Color.Aqua;
			this.aGauge2.RangeEnabled = true;
			this.aGauge2.RangeEndValue = 10F;
			this.aGauge2.RangeInnerRadius = 70;
			this.aGauge2.RangeOuterRadius = 80;
			this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
			this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
			this.aGauge2.RangesEndValue = new float[] {
        10F,
        100F,
        0F,
        0F,
        0F};
			this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
			this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
			this.aGauge2.RangesStartValue = new float[] {
        -20F,
        70F,
        0F,
        0F,
        0F};
			this.aGauge2.RangeStartValue = -20F;
			this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleLinesInterInnerRadius = 73;
			this.aGauge2.ScaleLinesInterOuterRadius = 80;
			this.aGauge2.ScaleLinesInterWidth = 1;
			this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleLinesMajorInnerRadius = 70;
			this.aGauge2.ScaleLinesMajorOuterRadius = 80;
			this.aGauge2.ScaleLinesMajorStepValue = 20F;
			this.aGauge2.ScaleLinesMajorWidth = 2;
			this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
			this.aGauge2.ScaleLinesMinorInnerRadius = 75;
			this.aGauge2.ScaleLinesMinorNumOf = 10;
			this.aGauge2.ScaleLinesMinorOuterRadius = 80;
			this.aGauge2.ScaleLinesMinorWidth = 1;
			this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleNumbersFormat = "00 *C";
			this.aGauge2.ScaleNumbersRadius = 95;
			this.aGauge2.ScaleNumbersRotation = 0;
			this.aGauge2.ScaleNumbersStartScaleLine = 0;
			this.aGauge2.ScaleNumbersStepScaleLines = 1;
			this.aGauge2.Size = new System.Drawing.Size(211, 186);
			this.aGauge2.TabIndex = 12;
			this.aGauge2.Text = "Temperature";
			this.aGauge2.Value = 0F;
			// 
			// Gauge_AmbientTemp
			// 
			this.Gauge_AmbientTemp.BaseArcColor = System.Drawing.Color.Gray;
			this.Gauge_AmbientTemp.BaseArcRadius = 80;
			this.Gauge_AmbientTemp.BaseArcStart = 135;
			this.Gauge_AmbientTemp.BaseArcSweep = 270;
			this.Gauge_AmbientTemp.BaseArcWidth = 2;
			this.Gauge_AmbientTemp.Cap_Idx = ((byte)(1));
			this.Gauge_AmbientTemp.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
			this.Gauge_AmbientTemp.CapPosition = new System.Drawing.Point(10, 10);
			this.Gauge_AmbientTemp.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
			this.Gauge_AmbientTemp.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
			this.Gauge_AmbientTemp.CapText = "";
			this.Gauge_AmbientTemp.Center = new System.Drawing.Point(100, 100);
			this.Gauge_AmbientTemp.Location = new System.Drawing.Point(12, 41);
			this.Gauge_AmbientTemp.MaxValue = 100F;
			this.Gauge_AmbientTemp.MinValue = -20F;
			this.Gauge_AmbientTemp.Name = "Gauge_AmbientTemp";
			this.Gauge_AmbientTemp.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
			this.Gauge_AmbientTemp.NeedleColor2 = System.Drawing.Color.DimGray;
			this.Gauge_AmbientTemp.NeedleRadius = 80;
			this.Gauge_AmbientTemp.NeedleType = 0;
			this.Gauge_AmbientTemp.NeedleWidth = 5;
			this.Gauge_AmbientTemp.Range_Idx = ((byte)(0));
			this.Gauge_AmbientTemp.RangeColor = System.Drawing.Color.Aqua;
			this.Gauge_AmbientTemp.RangeEnabled = true;
			this.Gauge_AmbientTemp.RangeEndValue = 10F;
			this.Gauge_AmbientTemp.RangeInnerRadius = 70;
			this.Gauge_AmbientTemp.RangeOuterRadius = 80;
			this.Gauge_AmbientTemp.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
			this.Gauge_AmbientTemp.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
			this.Gauge_AmbientTemp.RangesEndValue = new float[] {
        10F,
        100F,
        0F,
        0F,
        0F};
			this.Gauge_AmbientTemp.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
			this.Gauge_AmbientTemp.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
			this.Gauge_AmbientTemp.RangesStartValue = new float[] {
        -20F,
        70F,
        0F,
        0F,
        0F};
			this.Gauge_AmbientTemp.RangeStartValue = -20F;
			this.Gauge_AmbientTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.Gauge_AmbientTemp.ScaleLinesInterInnerRadius = 73;
			this.Gauge_AmbientTemp.ScaleLinesInterOuterRadius = 80;
			this.Gauge_AmbientTemp.ScaleLinesInterWidth = 1;
			this.Gauge_AmbientTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.Gauge_AmbientTemp.ScaleLinesMajorInnerRadius = 70;
			this.Gauge_AmbientTemp.ScaleLinesMajorOuterRadius = 80;
			this.Gauge_AmbientTemp.ScaleLinesMajorStepValue = 20F;
			this.Gauge_AmbientTemp.ScaleLinesMajorWidth = 2;
			this.Gauge_AmbientTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
			this.Gauge_AmbientTemp.ScaleLinesMinorInnerRadius = 75;
			this.Gauge_AmbientTemp.ScaleLinesMinorNumOf = 10;
			this.Gauge_AmbientTemp.ScaleLinesMinorOuterRadius = 80;
			this.Gauge_AmbientTemp.ScaleLinesMinorWidth = 1;
			this.Gauge_AmbientTemp.ScaleNumbersColor = System.Drawing.Color.Black;
			this.Gauge_AmbientTemp.ScaleNumbersFormat = "00 *C";
			this.Gauge_AmbientTemp.ScaleNumbersRadius = 95;
			this.Gauge_AmbientTemp.ScaleNumbersRotation = 0;
			this.Gauge_AmbientTemp.ScaleNumbersStartScaleLine = 0;
			this.Gauge_AmbientTemp.ScaleNumbersStepScaleLines = 1;
			this.Gauge_AmbientTemp.Size = new System.Drawing.Size(211, 186);
			this.Gauge_AmbientTemp.TabIndex = 11;
			this.Gauge_AmbientTemp.Text = "Temperature";
			this.Gauge_AmbientTemp.Value = 0F;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Ambient Temperature";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(289, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Coolant Temperature";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(12, 246);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(447, 67);
			this.panel1.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Dew Point:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Humidity:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(231, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "TEC State:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "TURN TEC OFF";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(332, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 23);
			this.button2.TabIndex = 21;
			this.button2.Text = "TURN TEC ON";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(95, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "00 *C";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(95, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "00 %";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(329, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 13);
			this.label8.TabIndex = 24;
			this.label8.Text = "OFF";
			// 
			// Form_MainDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 325);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.aGauge2);
			this.Controls.Add(this.Gauge_AmbientTemp);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_MainDisplay";
			this.Text = "TEC Companion";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private AGaugeApp.AGauge Gauge_AmbientTemp;
		private AGaugeApp.AGauge aGauge2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem File_Menu;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}

