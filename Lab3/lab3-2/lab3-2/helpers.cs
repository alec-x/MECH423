using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        private void setPort()
        {
            try
            {
                serialPort.BaudRate = Convert.ToInt32(baudRateText.Text);
                serialPort.PortName = comCombo.SelectedItem.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not set serial Port parameters");
                Console.WriteLine(exception.Message);
            }
        }

        private void toggleConnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    connectButton.Text = "Connect";
                    Console.WriteLine(String.Format("Disconnected from serial port {0}", serialPort.PortName));
                }
                else
                {
                    setPort();
                    serialPort.Open();
                    connectButton.Text = "Disconnect";
                    Console.WriteLine(String.Format("Connected to serial port {0}", serialPort.PortName));
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error connecting to port, try reselecting the port in the drop down menu");
            }

        }

        private void updatePortList()
        {
            comCombo.Items.Clear();
            comCombo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void changePort()
        {
            try
            {
                serialPort.Close();
                connectButton.Text = "Connect";
                Console.WriteLine("Closed previous serial port");
                serialPort.PortName = comCombo.Text;
            }
            catch
            {
                Console.WriteLine("An error occurred while changing ports, please try again");
            }
        }

        private void sendBytes()
        {
            try
            {
                if (duty2Text.Text != "" && duty1Text.Text != "" &&
                    directionText.Text != "" && escapeText.Text != "")
                {
                    TxBytes[0] = Convert.ToByte(255);
                    TxBytes[1] = Convert.ToByte(duty2Text.Text);
                    TxBytes[2] = Convert.ToByte(duty1Text.Text);
                    TxBytes[3] = Convert.ToByte(directionText.Text);
                    TxBytes[4] = Convert.ToByte(escapeText.Text);
                }
                for (int i = 0; i < 5; i++)
                {
                    serialPort.Write(TxBytes, i, 1);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Could not send bytes");
                Console.WriteLine(exception.Message);
            }

        }
    }
}
