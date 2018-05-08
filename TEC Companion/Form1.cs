using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TEC_Companion
{
    public partial class Form_MainDisplay : Form
    {
		//Arduino Port
		ArduinoController arduinoController;
		Form_Options optionsForm;

		public Form_MainDisplay()
        {
            InitializeComponent();
			arduinoController = new ArduinoController(this);
			optionsForm = new Form_Options(arduinoController);
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			optionsForm.Show();
		}

		public void setAmbientGaugeTemp(float value)
		{
			Gauge_AmbientTemp.Value = value;
		}
	}
}
