using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TEC_Companion
{
    public partial class Form1 : Form
    {
        //Arduino Port
        string arduinoCOMPort = "";
		string buffer = "";
		SerialPort arduinoPort;

        public Form1()
        {
            InitializeComponent();
			

        }

        private void Button_ReadCOM_Click(object sender, EventArgs e)
        {
            //Read all COM Ports...
            ComboBox_COMPorts.Items.Clear();
            string[] COMPorts = SerialPort.GetPortNames();

            foreach(string port in COMPorts)
            {
                ComboBox_COMPorts.Items.Add(port);
            }
        }

        private void ComboBox_COMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When port is selected, attach listener to port
            arduinoCOMPort = ComboBox_COMPorts.SelectedItem.ToString();
			arduinoPort = new SerialPort(arduinoCOMPort);
			arduinoPort.Open();
			arduinoPort.DataReceived += dataReceived;
        }

		private void dataReceived(Object o, SerialDataReceivedEventArgs e)
		{
			buffer += arduinoPort.ReadExisting();

			
			if (buffer.Contains("\n"))
			{
				string[] received = buffer.Split(',');

				buffer = "";

				if (received.Length != 3)
					return;

				string ambientTemp = received[0] + " *C";
				string humidity = received[1] + " %";
				string dewPoint = received[2].Replace("\n", "") + " *C";

				this.PerformSafely(() => Label_AmbientTemp.Text = ambientTemp);
				this.PerformSafely(() => Label_Humidity.Text = humidity);
				this.PerformSafely(() => Label_DewPoint.Text = dewPoint);

			}
		}
    }
}
