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
    public partial class loginLog : Form
    {
        public loginLog()
        {
            InitializeComponent();
        }


        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmLog formOpen = new alarmLog();
            this.Hide();
            formOpen.Show();
        }

        private void senorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor formOpen = new Sensor();
            this.Hide();
            formOpen.Show();
        }

        private void sensorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sensorLog formOpen = new sensorLog();
            this.Hide();
            formOpen.Show();
        }
    }
}
