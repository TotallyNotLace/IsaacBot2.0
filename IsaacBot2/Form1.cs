using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaacBot2
{
    public partial class mainForm : Form
    {

        // event here
        public event Action<string> CallConsole;

        TwitchClientConnector connector;

        public mainForm()
        {
            InitializeComponent();
            CallConsole += UpdateTextInConsole;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ToggleObjects(false);
            StartTheBot();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ToggleObjects(true);
            connector.StopBot();
        }

        private void StartTheBot()
        {
            //if a connector was not made already, make a new one
            if(connector == null)
            {
                connector = new TwitchClientConnector();
            }

            //activate the twitch connector
            connector.BotActivator(OnBotMessageReceived);
        }

        private void ToggleObjects(bool enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
        }

        private void btnDoThings_Click(object sender, EventArgs e)
        {

        }

        //delegate thats passed to things.
        private void OnBotMessageReceived(string message)
        {
            CallConsole?.Invoke(message);
        }

        private void UpdateTextInConsole(string message)
        {
            // Ensure this runs on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTextInConsole), message);
            }
            else
            {
                txtConsole.AppendText(message + Environment.NewLine); // Assuming a TextBox named txtConsole
            }
        }
    }
}
