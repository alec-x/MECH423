using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialReaderSuperSimple
{
    public partial class FormSerialReader : Form
    {
        public FormSerialReader()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = ListComPort.Text;
            Boolean isOpen = true;
        }

        private void ListComPort_MouseClick(object sender, MouseEventArgs e)
        {
            ListComPort.Items.Clear();
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            foreach (string name in portNames)
            {
                ListComPort.Items.Add(name);
            }
        }

        private void FormSerialReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort.Close();
        }
    }
}
