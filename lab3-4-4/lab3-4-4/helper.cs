using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4_4
{
    public partial class Form1 : Form
    {
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

        private void readSerial()
        {
            int newByte;

            while (serialPort.BytesToRead != 0)
            {
                newByte = serialPort.ReadByte();
                dataBuffer.Enqueue(newByte);
            }
        }

        private void readSerialBuffer()
        {
            int firstByte = 0;
            int encoderUp, encoderDown;
            bool continueRead = true;
            int up1, up0, down1, down0, escape;
            while (firstByte != 255 && !dataBuffer.IsEmpty)
            {
                dataBuffer.TryDequeue(out firstByte);
            }
            while (dataBuffer.Count >= 5 && firstByte == 255 && continueRead)
            {
                dataBuffer.TryDequeue(out up1);
                dataBuffer.TryDequeue(out up0);
                dataBuffer.TryDequeue(out down1);
                dataBuffer.TryDequeue(out down0);
                dataBuffer.TryDequeue(out escape);
                if (dataBuffer.Count >= 6)
                {
                    dataBuffer.TryDequeue(out firstByte);
                    continueRead = true;
                }
                else
                {
                    continueRead = false;
                }

                if ((escape & 1) == 1)
                {
                    up1 = 255;
                }
                if ((escape & 2) == 2)
                {
                    up0 = 255;
                }
                if ((escape & 4) == 4)
                {
                    down1 = 255;
                }
                if ((escape & 8) == 8)
                {
                    down0 = 255;
                }
                encoderUp = (up1 << 8) + up0;
                encoderDown = (down1 << 8) + down0;
                while (averagePos.Count >= 100)
                {
                    averagePos.RemoveAt(0);
                }
                averagePos.Add(encoderUp - encoderDown);
                totalPos += (Int32)encoderUp - (Int32)encoderDown;
                
                if(totalPos >= 360)
                {
                    totalPos = totalPos % 360;
                }
                if(totalPos < 0)
                {
                    totalPos = totalPos % 360;
                }
                
                //chart1.Series[0].Points.DataBindY(averagePos);
            }
        }

        void sendBytes(double pwmPercentage)
        {
            try
            {
                byte[] TxBytes = new byte[5];
                
                byte dataByte1, dataByte2;

                    pwmConverted = pwmPercentage /100 * 255 * 255;
                    dataByte1 = Convert.ToByte((int)pwmConverted >> 8);
                    dataByte2 = Convert.ToByte((int)pwmConverted % 255);

                    TxBytes[0] = Convert.ToByte(255);
                    TxBytes[1] = dataByte1;
                    TxBytes[2] = dataByte2;
                    if (directionCheck.Checked)
                    {
                        TxBytes[3] = Convert.ToByte(0);
                    }
                    else
                    {
                        TxBytes[3] = Convert.ToByte(1);
                    }
                    if (dataByte1 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(1);
                        TxBytes[1] = Convert.ToByte(254);
                    }
                    else if (dataByte2 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(2);
                        TxBytes[2] = Convert.ToByte(254);
                    } else if (dataByte1 == 255 && dataByte2 == 255)
                    {
                        TxBytes[4] = Convert.ToByte(3);
                        TxBytes[2] = Convert.ToByte(254);
                        TxBytes[1] = Convert.ToByte(254);
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

        private void updateSpeed()
        {
            // 1000 for ms to s, 360 for window count to rotation
            try
            {
                // 60sec/min * 1000ms/s / 360count/rotation / 6datapoints-averaged = 25 (missing factor of 2?)
                currVelocity = 27.78 * 2 * (double)averagePos.GetRange(94, 6).Sum() / timeCounter ;
                while (velocity.Count >= 100)
                {
                    velocity.RemoveAt(0);
                }
                velocity.Add(currVelocity);
                speedRPMText.Text = (velocity.GetRange(90,10).Sum() / 10).ToString();
                //  60 / 2 / 3.1416 for RPM to rad
                speedHzText.Text = (9.549* (velocity.GetRange(90, 10).Sum() / 10)).ToString();
                positionText.Text = totalPos.ToString();
            }
            catch
            {
                speedRPMText.Text = "INITIALIZING";
                positionText.Text = "INITIALIZING";
            }
        }

        private void modulateSpeed() {
            double gain = 1;
            int direction = 0; 
            try
            {   
                if(currVelocity >= Convert.ToInt16(posModText.Text))
                {
                    speedModText.Text = (currVelocity - Convert.ToInt16(posModText.Text)).ToString();
                }
                else
                {
                    speedModText.Text = (Convert.ToInt16(posModText.Text) - currVelocity).ToString();
                }
                                
            }
            catch
            {
                speedModText.Text = "INITIALIZING";
            }
        }
    }
}
