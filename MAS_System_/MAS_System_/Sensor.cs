using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_System_
{
    
    public partial class Sensor : Form
    {
        double tempLvl;
        double smokeLvl;
        double humLvl;
        double humThresh= 55;
        double tempThresh = 60.5;
        double smokeThresh= 200;
        double tempMax = 300.00;
        double humMax=100.00;
        double smokeMax =900.00;
        string[] sensor = new string[3];
        bool closed = false;
        private SqlCommand command;
        private SqlDataReader dataReader;
        private BackgroundWorker bw;
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static private string conn = "Server=tcp:mas-team-3-477.database.windows.net,1433;Database=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection myConn= new SqlConnection(conn);

        public Sensor()
        {
            InitializeComponent();
            this.smokeBW = new BackgroundWorker();
            this.smokeBW.DoWork += new DoWorkEventHandler(smokeBW_DoWork);
            this.smokeBW.ProgressChanged += new ProgressChangedEventHandler(smokeBW_ProgressChanged);
            this.smokeBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(smokeBW_RunWorkerCompleted);
            this.smokeBW.WorkerReportsProgress = true;

            this.bw = new BackgroundWorker();
            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            this.bw.WorkerReportsProgress = true;

            this.humBW = new BackgroundWorker();
            this.humBW.DoWork += new DoWorkEventHandler(humBW_DoWork);
            this.humBW.ProgressChanged += new ProgressChangedEventHandler(humBW_ProgressChanged);
            this.humBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(humBW_RunWorkerCompleted);
            this.humBW.WorkerReportsProgress = true;
            //thread starts 
            new Thread(ThreadStart).Start();
            new Thread(smokeThreadStart).Start();
            new Thread(humThreadStart).Start();
            Random rand1 = new Random();
        }

        private void humThreadStart()
        {
            humBW.RunWorkerAsync();
        }

        private void smokeThreadStart()
        {
            smokeBW.RunWorkerAsync();
        }

        private void Sensor_Load(object sender, EventArgs e)
        {

            humityThreshTxt.Text = humThresh.ToString();
            smokeThreshTxt.Text = smokeThresh.ToString();
            tempThreshTxt.Text = tempThresh.ToString();
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
        }


       

        

       
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string varConvert = e.ProgressPercentage.ToString();
            AppendTextBox(varConvert);
        }
        //the temp sen background worker
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand1 = new Random();
            double[] sensMax = { 300.00, 100.00, 900.00 };
            double[] sensMin = { 32.00, 0.00, 0.00 };
            BackgroundWorker worker2 = (BackgroundWorker)sender;

            do
            {
                if (!this.bw.IsBusy)
                {
                    this.bw.RunWorkerAsync();
                }
                else
                {


                    double sensor = (rand1.NextDouble() * (sensMax[0] - sensMin[0])) + 1;
                    int sensConvert = Convert.ToInt32(sensor);
                    sender = sensConvert;
                    worker2.ReportProgress(sensConvert);

                    //temp set

                    //passing the 

                    //sleeping the system for 60 seconds 
                    System.Threading.Thread.Sleep(60000);

                }
            } while (closed == false);

        }


        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string varConvert = e.Result.ToString();
            AppendTextBox(varConvert);

        }

       void ThreadStart()
        {
            if (!this.bw.IsBusy)
            {
                this.bw.RunWorkerAsync();
            }
        }

        private void AppendTextBox(string v)
        {
            string query = "INSERT INTO sensorLog(vaule, sensorName )VALUES(" + v + "Temp" + ")";

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { v });
                return;
            }
            tempLvlTxt.Text = v;
            SqlConnection connection = new SqlConnection(conn);
            
            try
            {
               
                connection.Open();
                command = new SqlCommand(query, connection);
                SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);

                
               
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
           
           
        }

        private void AppendHumTxt(string v)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendHumTxt), new object[] { v });
                return;
            }
            humityTxt.Text = v;
        }
        private void AppendSmokeTxt(string v)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendSmokeTxt), new object[] { v });
                return;
            }
            smokeLvlTxt.Text = v;
          
        }


        private void Sensor_FormClosing(object sender, FormClosingEventArgs e)
        {
            closed = true;

        }

        private void smokeBW_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand1 = new Random();
            double[] sensMax = { 300.00, 100.00, 900.00 };
            double[] sensMin = { 32.00, 0.00, 0.00 };
            BackgroundWorker worker2 = (BackgroundWorker)sender;
           
            do
            {
                if (!this.bw.IsBusy)
                {
                    this.bw.RunWorkerAsync();
                }
                else
                {

                   
                       double sensor = (rand1.NextDouble() * (sensMax[2] - sensMin[2])) + 1;
                       int sensConvert = Convert.ToInt32(sensor);
                       sender = sensConvert;
                       worker2.ReportProgress(sensConvert);

                   
                    //temp set

                    //passing the 

                    //sleeping the system for 60 seconds 
                    System.Threading.Thread.Sleep(60000);

                }
            } while (closed == false);
        }

        private void smokeBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           string varConvert = e.ProgressPercentage.ToString();
            AppendSmokeTxt(varConvert);
        }

        private void smokeBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string varConvert = e.Result.ToString();
            AppendSmokeTxt(varConvert);
        }

        private void humBW_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand1 = new Random();
            //limt vars 
            double[] sensMax = { 300.00, 100.00, 900.00 };
            double[] sensMin = { 32.00, 0.00, 0.00 };
            BackgroundWorker worker1 = (BackgroundWorker)sender;

            do
            {
                if (!this.bw.IsBusy)
                {
                    this.bw.RunWorkerAsync();
                }
                else
                {
                    // doing a rand function into a double 
                    double sensor = (rand1.NextDouble() * (sensMax[1] - sensMin[1])) + 1;
                    int sensConvert = Convert.ToInt32(sensor);
                    //passing the var that was genrated
                    worker1.ReportProgress(sensConvert);
                    //sleeping the system for 60 seconds 
                    System.Threading.Thread.Sleep(60000);

                }
            } while (closed == false);
        }

        private void humBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string varConvert = e.ProgressPercentage.ToString();
            AppendHumTxt(varConvert);
        }

        private void humBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string varConvert = e.Result.ToString();
            AppendHumTxt(varConvert);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sensorLog formOpen = new sensorLog();
            this.Hide();
            formOpen.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginLog formOpen = new loginLog();
            this.Hide();
            formOpen.Show();
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmLog formOpen = new alarmLog();
            this.Hide();
            formOpen.Show();
        }
    }
}
