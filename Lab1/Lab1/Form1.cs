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
using System.Linq;

namespace Lab1
{
    public partial class MainForm : Form
    {

        ConcurrentQueue<int> serialReadQueue = new ConcurrentQueue<int>();
        List<int> xAvgList = new List<int>();
        List<int> yAvgList = new List<int>();
        List<int> zAvgList = new List<int>();
        bool moveTrigger = false;
        string currentDirection;
        int moveTimer = 0;
        int delay = 0;
        int moveDisplay;
        
        
        string currentMove;
        string comboList = "";
        IDictionary<string, int> moveSum = new Dictionary<string, int>()
        {
            {" +X", 0},
            {" -X", 0},
            {" +Y", 0},
            {" -Y", 0},
            {" +Z", 0},
            {" -Z", 0}
        };
        IDictionary<string, string> moveList = new Dictionary<string, string>()
        {
            {" +X", "Simple Punch" },
            {" +Z +X", "High Punch" },
            {" +X +Y +Z", "Right-Hook" },
            {" +Z -Z, +Z", "Kame Hame Ha" }
        };
        IDictionary<string, List<int>> orientationList = new Dictionary<string, List<int>>();
        
        static List<System.Windows.Forms.PictureBox> moleList = new List<System.Windows.Forms.PictureBox>();
        private WhackAMoleGame game = new WhackAMoleGame(ref moleList);

        public MainForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(moveDisplay <= 0 && SerialPort.IsOpen && xAvgList.Count >99)
            {
                TextMovePerformed.Text = "";
                if (moveTimer >= 2000 || !moveTrigger)
                {
                    recognizeMoves();
                    resetMoves();
                }
                else
                {
                    moveTimer += Timer.Interval;
                }

                if(delay > 0)
                {
                    delay -= Timer.Interval;
                }
                else
                {
                    currentDirection = recognizeCurrentDirection();
                }
                
                if(currentDirection != "")
                {
                    delay = 200;
                }
                comboList += currentDirection;
                
                
            }
            else
            {
                moveDisplay -= Timer.Interval;
            }

            if (game.GetState() == 1)
            {
                game.GameLoop(currentDirection);
            }

            currentDirection = ""; //put current direction here so gameloop could piggyback
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

            moleList.Add(PictureUp);
            moleList.Add(PictureDown);
            moleList.Add(PictureLeft);
            moleList.Add(PictureRight);
            moleList.Add(PictureMiddle);

            ComboLevel.Items.Add("1");
            ComboLevel.Items.Add("2");
            ComboLevel.Items.Add("3");
        }

        private void ButtonGameStart_Click(object sender, EventArgs e)
        {
            game.GameStart(int.Parse(ComboLevel.SelectedItem.ToString()));
        }
    }
}
