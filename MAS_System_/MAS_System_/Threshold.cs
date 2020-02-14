using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_System_
{
    public partial class Threshold : Form
    {
        public Threshold()
        {
            InitializeComponent();
        }



        private void setThreshBtn_Click(object sender, EventArgs e)
        {


            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insert = "insert into threshold (threshId, threholdName, thresholdVaule, dateTime) values (@threshId,@threholdName,@thresholdVaule,@dateTime)";

            using (sqlCon)
            {
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(threshId) from threshold";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //placing the max pk into a var and adding 1 to it 
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }
                        else
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }


                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@threholdName", tempThreshNewLbl.Text.Trim());
                    cmd.Parameters.AddWithValue("@thresholdVaule", tempNewThreshTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                    int result = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    if (result < 0)
                        MessageBox.Show("Error inserting data into Database!");
                }
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(threshId) from threshold";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //placing the max pk into a var and adding 1 to it 
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }
                        else
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }


                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@threholdName", threshSmokeNewLbl.Text.Trim());
                    cmd.Parameters.AddWithValue("@thresholdVaule", smokeThreshNewBtn.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                    int result = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    if (result < 0)
                        MessageBox.Show("Error inserting data into Database!");

                  

                }
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting the max PK for the table 
                    string pkcheck = "Select max(threshId) from threshold";
                    SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                    sqlCon.Open();
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //placing the max pk into a var and adding 1 to it 
                        int readReturn;
                        if (reader == null)
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }
                        else
                        {
                            readReturn = reader.GetInt32(0);
                            cmd.Parameters.AddWithValue("@threshId", readReturn + 1);
                        }


                    }
                    //closing the connection to the data base 
                    sqlCon.Close();
                    //getting the date and time 
                    DateTime dateTime = DateTime.Now;
                    //adding all current vars to the data base 
                    cmd.Parameters.AddWithValue("@threholdName", humThreshNewlbl.Text.Trim());
                    cmd.Parameters.AddWithValue("@thresholdVaule", humThreshNewBtn.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    //excuting the command 
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                        MessageBox.Show("Error inserting data into Database!");

                    
                }
                
            }
            Sensor form = new Sensor();
            this.Hide();
            form.Show();
            this.Close();
        }

        private void cancelThreshBtn_Click(object sender, EventArgs e)
        {
            Sensor form = new Sensor();
            this.Hide();
            form.Close();
            form.Show();
            this.Close();
        }
    }
}


    
    