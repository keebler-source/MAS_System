using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_System_
{
    public partial class sensorLog : Form
    {
        public sensorLog()
        {
            InitializeComponent();
        }

        private void alramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmLog openForm = new alarmLog();
            this.Hide();
            openForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginLog openForm = new loginLog();
            this.Hide();
            openForm.Show();
        }

        private void sensorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sensor formOpen = new Sensor();
            this.Hide();
            formOpen.Show();
        }
    }
}
