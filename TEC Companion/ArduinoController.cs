using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TEC_Companion
{
	public class ArduinoController
	{
		private string arduinoCOMPort = "";
		private string buffer = "";
		private SerialPort arduinoPort;
		private Form_MainDisplay mainForm;

		public ArduinoController(Form_MainDisplay mainForm)
		{
			this.mainForm = mainForm;
		}

		//Select new COM port
		public void SelectCOMPort(string COMPort)
		{
			//When port is selected, attach listener to port
			arduinoCOMPort = COMPort;
			arduinoPort = new SerialPort(arduinoCOMPort);
			arduinoPort.Open();
			arduinoPort.DataReceived += dataReceived;
		}

		//Read all COM Ports...
		public string[] ReadComPorts()
		{
			string[] COMPorts = SerialPort.GetPortNames();

			return COMPorts;
		}

		//On Data Received
		private void dataReceived(object o, SerialDataReceivedEventArgs e)
		{
			buffer += arduinoPort.ReadExisting();


			if (buffer.Contains("\n"))
			{
				string[] received = buffer.Split(',');

				buffer = "";

				if (received.Length != 3)
					return;

				float ambientTemp = -50.00f;
				float humidity;
				float dewPoint;

				try
				{
					ambientTemp = float.Parse(received[0]);
				} catch(Exception ex)
				{
					MessageBox.Show("Failed to convert ambient temp to float - " + ex.ToString());
				}

				mainForm.PerformSafely(() => mainForm.setAmbientGaugeTemp(ambientTemp));
				

			}
		}
	}
}
