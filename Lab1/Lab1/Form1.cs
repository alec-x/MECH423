using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace Lab1
{
    public partial class MainForm : Form
    {

        ConcurrentQueue<int> serialReadQueue = new ConcurrentQueue<int>();
        List<int> xAvgList = new List<int>();
        List<int> yAvgList = new List<int>();
        List<int> zAvgList = new List<int>();
        int moveTimer = 0;
        string comboList = "";
        IDictionary<string, string> moveList = new Dictionary<string, string>()
        {
            {" X", "Simple Punch" },
            {" Z X", "High Punch" },
            {" X Y Z", "Right-Hook" }
        };
        IDictionary<string, List<int>> orientationList = new Dictionary<string, List<int>>();
        BindingSource chartSource = new BindingSource();
        private WhackAMoleGame game = new WhackAMoleGame();


        public MainForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (moveTimer >= 2000)
            {
                moveTimer = 0;
                comboList = "";
            }

            moveTimer += Timer.Interval;



            updateBufferBar();
            readBuffer();
            updateChart();
            TextBoardOrientation.Text = GetOrientation();

        }

        private void ComboPortList_MouseClick(object sender, MouseEventArgs e)
        {
            ComboPortList.Items.Clear();
            ComboPortList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort.Close();
        }

        private void ComboPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
                ButtonConnect.Text = "Connect";
                Console.WriteLine("Closed previous serial port");
                SerialPort.PortName = ComboPortList.Text;
            }
            catch
            {
                Console.WriteLine("An error occurred while changing ports, please try again");
            }
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //References Sept 7, 2018 12PM Lecture.
            int newByte;

            while (SerialPort.BytesToRead != 0)
            {
                newByte = SerialPort.ReadByte();
                serialReadQueue.Enqueue(newByte);
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort.IsOpen)
                {
                    SerialPort.Close();
                    ButtonConnect.Text = "Connect";
                    Console.WriteLine(String.Format("Disconnected from serial port {0}", SerialPort.PortName));
                }
                else
                {
                    SerialPort.Open();
                    ButtonConnect.Text = "Disconnect";
                    Console.WriteLine(String.Format("Connected to serial port {0}", SerialPort.PortName));
                }
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error connecting to port, try reselecting the port in the drop down menu");
            }
            catch
            {
                Console.WriteLine("No clue what happened, not a System.IO.IOException");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboPortList.Items.Clear();
            ComboPortList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            List<int> flatList = new List<int> { 0, 0, 0 };
            orientationList.Add("flat", flatList);
            List<int> leftList =new List<int> { -25, 2, -27 };
            orientationList.Add("left", leftList);
            List<int> rightList =new List<int> { 27, 0, -23 };
            orientationList.Add("right", rightList);
            List<int> upList =new List<int> { 0, -26, -26 };
            orientationList.Add("up", upList);
            List<int> downList =new List<int> { 0, 27, -27 };
            orientationList.Add("down", downList);
            List<int> flippedList =new List<int> { 0, 0, -50 };
            orientationList.Add("flipped", flippedList);
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {

        }


    }
}
