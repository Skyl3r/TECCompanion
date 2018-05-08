using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEC_Companion
{
	public partial class Form_Options : Form
	{

		ArduinoController arduinoController;

		public Form_Options(ArduinoController controller)
		{
			InitializeComponent();
			arduinoController = controller;
		}

		private void Button_Accept_Click(object sender, EventArgs e)
		{
			//No Changes to write yet...
			//Just close...

			Hide();
		}

		private void Button_COMRefresh_Click(object sender, EventArgs e)
		{
			string[] ports = arduinoController.ReadComPorts();
			ComboBox_COMPorts.Items.Clear();

			foreach(string port in ports)
			{
				ComboBox_COMPorts.Items.Add(port);
			}
		}
	}
}
