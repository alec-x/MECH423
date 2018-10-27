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
        byte[] TxBytes = new Byte[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            toggleConnect();
        }

        private void comCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePort();
        }

        private void comCombo_Click(object sender, EventArgs e)
        {
            updatePortList();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
