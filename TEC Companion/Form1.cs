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

		public void setDewPointLabel(float dewPoint)
		{
			Label_DewPoint.Text = dewPoint + " *C";
		}

		public void setHumidityLabel(float humidity)
		{
			Label_Humidity.Text = humidity + " %";
		}

		public void setPeltierStateLabel(float state)
		{
			if(state == 0.00f)
			{
				Label_TECState.Text = "OFF";
			}

			if(state != 0.00f)
			{
				Label_TECState.Text = "ON";
			}
		}

		private void Button_TECOn_Click(object sender, EventArgs e)
		{
			arduinoController.sendData("1");
		}

		private void Button_TECOff_Click(object sender, EventArgs e)
		{
			arduinoController.sendData("0");
		}
	}
}
