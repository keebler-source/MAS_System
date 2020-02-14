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
        double humThresh;
        double tempThresh;
        double smokeThresh;
       
        string[] sensor = new string[3];
        bool closed = false;
        private BackgroundWorker bw;
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static private string conn = "Server=tcp:mas-team-3-477.database.windows.net,1433;Database=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection myConn = new SqlConnection(conn);

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


            //loading the sensror threshold 
            //sql connection setup 

           
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
           // tempThreshTxt.Text = tempThresh.ToString();
            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (sqlCon)
            {
                //sql commands 
                string selectTemp = "select top 1 thresholdVaule from threshold where threholdName = 'Temperature' order by threshId desc";
                string selectSmoke = "select top 1 thresholdVaule from threshold where threholdName = 'Smoke' order by threshId desc";
                string selectHum = "select top 1 thresholdVaule from threshold where threholdName = 'Humidity' order by threshId desc";
                //created the connection and using the query 
                SqlCommand cmd1 = new SqlCommand(selectTemp, sqlCon);
                SqlCommand cmd2 = new SqlCommand(selectSmoke, sqlCon);
                SqlCommand cmd3 = new SqlCommand(selectHum, sqlCon);
                //opening the connection to the data base 
                sqlCon.Open();
                // creating the readers
                SqlDataReader reader = cmd1.ExecuteReader();
               
                //sql reader for temp
                while (reader.Read())
                {
                    tempThreshTxt.Text = reader[0].ToString();
                    tempThresh = Convert.ToDouble(reader[0]);
                }
                sqlCon.Close();
                //sql smokeReader
                sqlCon.Open();
                SqlDataReader smokeReader = cmd2.ExecuteReader();
                while (smokeReader.Read())
                {
                    smokeThreshTxt.Text = smokeReader[0].ToString();
                    smokeThresh = Convert.ToDouble(smokeReader[0]);
                }
                sqlCon.Close();
                //hum reader 
                sqlCon.Open();
                SqlDataReader humReader = cmd3.ExecuteReader();
                while (humReader.Read())
                {
                    humityThreshTxt.Text = humReader[0].ToString();
                    humThresh = Convert.ToDouble(humReader[0]);
                }
                sqlCon.Close();
              
            }
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
            double[] sensMax = { 80.00, 75.00, 300.00 };
            double[] sensMin = { 55.00, 45.00, 0.00 };
            BackgroundWorker worker2 = (BackgroundWorker)sender;

            do
            {
                if (!this.bw.IsBusy)
                {
                    this.bw.RunWorkerAsync();
                }
                else
                {
                    //vaule create 
                    double sensor = (rand1.NextDouble() * (sensMax[0] - sensMin[0])) + 1;
                    int sensConvert = Convert.ToInt32(sensor);
                    sender = sensConvert;
                    //sending the work done 
                    worker2.ReportProgress(sensConvert);
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
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { v });
                return;
            }
            tempLvlTxt.Text = v;
            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insert = "insert into tempSensor (TempId, sensorName, sensorValue, dateTime) values (@TempId,@sensorName,@sensorValue,@dateTime)";
            using (sqlCon)
            {
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(tempID) from tempSensor";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@TempID", readReturn + 1);
                        }
                        else
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@TempID", readReturn + 1);
                        }
                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@sensorName", tempLBL.Text.Trim());
                    cmd.Parameters.AddWithValue("@sensorValue", tempLvlTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                    int result = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    if (result < 0)
                        MessageBox.Show("Error inserting data into Database!");

                }

                double testVaule = Convert.ToDouble(v);
                if (testVaule >= tempThresh)
                {
                    var results = MessageBox.Show("The Temp threshold was exeted", "Would you like to reset ",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    //will add the wait time here if the user does not select anything 

                    if (results == DialogResult.No)
                    {
                        DateTime dateTime = new DateTime();
                        string threshInsert = "insert into alarmLogs(sensorName,sensorVaule,threshold,dateTime)values(@sensorName, @sensorVaule,@threshold, @dateTime)";
                        using (sqlCon)
                        {
                            using (SqlCommand cmd = new SqlCommand(threshInsert, sqlCon))
                            {
                                //getting the max PK for the table 
                                
                                sqlCon.Open();

                                //closing the connection to the data base 
                                sqlCon.Close();
                                //getting the date and time 

                                //adding all current vars to the data base 
                                cmd.Parameters.AddWithValue("@sensorName", tempLBL.Text.Trim());
                                cmd.Parameters.AddWithValue("@sensorVaule", tempLvlTxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@threshold", tempThresh);
                                cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                                sqlCon.Open();
                                //excuting the command 
                                int result = cmd.ExecuteNonQuery();
                            }

                        }
                    }
                }
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
            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insert = "insert into humiditySensor (humidityId, sensorName, sensorValue, dateTime) values (@humidityId,@sensorName,@sensorValue,@dateTime)";
            using (sqlCon)
            {
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(humidityId) from humiditySensor";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon); 
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //placing the max pk into a var and adding 1 to it 
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@humidityId", readReturn + 1);
                        }
                        else
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@humidityId", readReturn + 1);
                        }

                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@sensorName", humLbl.Text.Trim());
                    cmd.Parameters.AddWithValue("@sensorValue", humityTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                    int result = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    if (result < 0)
                        MessageBox.Show("Error inserting data into Database!");
                    double testVaule = Convert.ToDouble(v);
                    if (testVaule >= humThresh)
                    {
                        var results = MessageBox.Show("The Humidity threshold was exeted", "Would you like to reset ",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                        //will add the wait time here if the user does not select anything 

                        if (results == DialogResult.No)
                        {
                            
                            string threshInsert = "insert into alarmLogs(sensorName,sensorVaule,threshold,dateTime)values( @sensorName, @sensorVaule,@threshold, @dateTime)";
                            using (sqlCon)
                            {
                                using (SqlCommand cmd11 = new SqlCommand(threshInsert, sqlCon))
                                {
                                    
                                    //closing the connection to the data base 
                                    sqlCon.Close();
                                    //getting the date and time 

                                    //adding all current vars to the data base 
                                    cmd11.Parameters.AddWithValue("@sensorName", humLbl.Text.Trim());
                                    cmd11.Parameters.AddWithValue("@sensorVaule", humityTxt.Text.Trim());
                                    cmd11.Parameters.AddWithValue("@threshold", humThresh);
                                    cmd11.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                                    sqlCon.Open();
                                    //excuting the command 
                                    int result11 = cmd11.ExecuteNonQuery();
                                    sqlCon.Close();
                                }

                            }
                        }
                    }
                }
            }
        }
        private void AppendSmokeTxt(string v)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendSmokeTxt), new object[] { v });
                return;
            }
            smokeLvlTxt.Text = v;
            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insert = "insert into smokeSensor (smokeId,sensorName,sensorValue,dateTime) values (@smokeId,@sensorName,@sensorValue,@dateTime)";
            using (sqlCon)

            using (sqlCon)
            {
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(smokeId) from smokeSensor";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //placing the max pk into a var and adding 1 to it 
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@smokeId", readReturn +1 );
                        }
                        else
                        {
                            readReturn = Convert.ToInt32(reader[0]);
                            cmd.Parameters.AddWithValue("@smokeId", readReturn+1);
                        }
                     
                        
                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@sensorName", smokeLbl.Text.Trim());
                    cmd.Parameters.AddWithValue("@sensorValue", smokeLvlTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                     int result = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                double testVaule = Convert.ToDouble(v);
                if (testVaule >= smokeThresh)
                {
                    var results = MessageBox.Show("The Smoke threshold was exeted", "Would you like to reset ",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    //will add the wait time here if the user does not select anything 

                    if (results == DialogResult.No)
                    {
                        DateTime dateTime = new DateTime();
                        string threshInsert = "insert into alarmLogs(sensorName,sensorVaule,threshold,dateTime)values(@sensorName, @sensorVaule,@threshold, @dateTime)";
                        using (sqlCon)
                        {
                            using (SqlCommand cmd = new SqlCommand(threshInsert, sqlCon))
                            {
                                //getting the max PK for the table 
                                
                                //closing the connection to the data base 
                                sqlCon.Close();
                                //getting the date and time 

                                //adding all current vars to the data base 
                                cmd.Parameters.AddWithValue("@sensorName", smokeLvlTxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@sensorVaule", smokeLvlTxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@threshold", smokeThresh);
                                cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                                sqlCon.Open();
                                //excuting the command 
                                int result = cmd.ExecuteNonQuery();
                            }

                        }
                    }

                }
            }
        }




        private void smokeBW_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand1 = new Random();
            double[] sensMax = { 80.00, 75.00, 300.00 };
            double[] sensMin = { 55.00, 45.00, 0.00 };
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
            double[] sensMax = { 80.00, 75.00, 300.00 };
            double[] sensMin = { 55.00, 45.00, 100.00 };
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
            Login form = new Login();
            form.Close();
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

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thresholdToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Threshold open = new Threshold();
            this.Hide();
            open.Show();
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.Show();
        }
    }
}
