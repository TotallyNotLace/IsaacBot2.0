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
        TwitchClientConnector connector;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ToggleObjects(false);
            StartTheBot();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ToggleObjects(true);
            connector = null;
            //unsub from events
            //delete object
            //enable objects
        }

        private void StartTheBot()
        {
            connector = new TwitchClientConnector();
        }

        private void ToggleObjects(bool enable)
        {
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
        }
    }
}
