﻿using System;
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
    public partial class alarmLog : Form
    {
        public alarmLog()
        {
            InitializeComponent();
        }

        private void sensorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Sensor formOpen = new Sensor();
            this.Show();
            formOpen.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginLog openForm = new loginLog();
            this.Hide();
            openForm.Show();
        }

        private void sensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensor formOpen = new Sensor();
            this.Show();
            formOpen.Show();
        }

        private void alarmLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAS_TEAM_3_477DataSet.alarmLogs' table. You can move, or remove it, as needed.
            this.alarmLogsTableAdapter.Fill(this.mAS_TEAM_3_477DataSet.alarmLogs);
            // TODO: This line of code loads data into the 'mAS_TEAM_3_477DataSet.alarmLog' table. You can move, or remove it, as needed.
            //this.alarmLogTableAdapter.Fill(this.mAS_TEAM_3_477DataSet.alarmLog);

        }

        private void alarmLogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alarmLogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mAS_TEAM_3_477DataSet);

        }
    }
}
