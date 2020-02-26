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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loginLogTableAdapter1.FillBy(this.mAS_TEAM_3_477DataSet.loginLog);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void loginLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAS_TEAM_3_477DataSet1.loginLog' table. You can move, or remove it, as needed.
            this.loginLogTableAdapter1.Fill(this.mAS_TEAM_3_477DataSet1.loginLog);
            // TODO: This line of code loads data into the 'mAS_TEAM_3_477DataSet1.threshold' table. You can move, or remove it, as needed.

        }
    }
}
