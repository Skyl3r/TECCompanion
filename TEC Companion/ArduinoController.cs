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

		public void sendData(string s)
		{
			if(arduinoPort == null)
			{
				MessageBox.Show("Please select COM port first!");
				return;
			}
			arduinoPort.Write(s);
		}

		//On Data Received
		private void dataReceived(object o, SerialDataReceivedEventArgs e)
		{
			buffer += arduinoPort.ReadExisting();

			if (buffer.Contains("\n"))
			{
				string[] received = buffer.Split(',');

				buffer = "";

				if (received.Length != 4)
					return;

				float ambientTemp	= -50.00f;
				float humidity		= -50.00f;
				float dewPoint		= -50.00f;
				float peltierState	= 0.00f;

				try
				{
					ambientTemp = float.Parse(received[0]);
				} catch(Exception ex)
				{
					MessageBox.Show("Failed to convert ambient temp to float - " + ex.ToString());
				}

				try
				{
					humidity = float.Parse(received[1]);
				} catch(Exception ex)
				{
					MessageBox.Show("Failed to convert humidity to float - " + ex.ToString());
				}


				try
				{
					dewPoint = float.Parse(received[2]);
				} catch(Exception ex)
				{
					MessageBox.Show("Failed to convert dew point to float - " + ex.ToString());
				}

				try
				{
					peltierState = float.Parse(received[3]);
				} catch(Exception ex)
				{
					MessageBox.Show("Failed to get peltier state - " + ex.ToString());
				}

				mainForm.PerformSafely(() => mainForm.setAmbientGaugeTemp(ambientTemp));
				mainForm.PerformSafely(() => mainForm.setDewPointLabel(dewPoint));
				mainForm.PerformSafely(() => mainForm.setHumidityLabel(humidity));
				mainForm.PerformSafely(() => mainForm.setPeltierStateLabel(peltierState));

			}
		}
	}
}
