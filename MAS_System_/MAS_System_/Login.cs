using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_System_
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            SqlConnection sqlCon = new SqlConnection(@"Data Source=mas-team-3-477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //string qurey
            string query = "SELECT * from dbo.[user] WHERE username='" + userNameTxt.Text.Trim() + "' AND password='" + passwrdTxt.Text.Trim() + "'";
            string check = "select * from dbo.[loginLog]";
            //data adapter
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table to see if the table has a user name and passwordmatch 
            sda.Fill(dt);
            //will check how many rows are in the loginLog table 
            SqlDataAdapter checksda = new SqlDataAdapter(check, sqlCon);
            DataTable checkDT = new DataTable();
            checksda.Fill(checkDT);
            //writes how many rows are in the table to pkgen
            int pkgen = checkDT.Rows.Count;
            if (dt.Rows.Count == 1)
            {
                string insert = "INSERT INTO dbo.loginLog(loginId, username, dateTime) VALUES(@loginId, @username, @dateTime)";
                using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
                {
                    //getting date and time 
                    DateTime dateTime = DateTime.Now;

                    //adds 1000 to pkgen 
                    cmd.Parameters.AddWithValue("@loginID", pkgen + 1000);
                    cmd.Parameters.AddWithValue("@username", userNameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    sqlCon.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }


                /* if the validation is true open sensor form */
                Sensor sensor = new Sensor();
                this.Hide();
                sensor.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and or password");
            }
        }
    }
}
