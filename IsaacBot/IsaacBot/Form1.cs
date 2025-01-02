using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaacBot
{
    public partial class mainForm : Form
    {
        private float numbers = 0;

        public mainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void sendMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessageTextBox.Text = "working";
            consoleTextBox.AppendText($"working {numbers} \r\n");
            numbers++;
        }
    }
}
