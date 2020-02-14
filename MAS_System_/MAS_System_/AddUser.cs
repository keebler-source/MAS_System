using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MAS_System_
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=massystem477.database.windows.net;Initial Catalog=MAS_TEAM_3_477;User ID=TEAM3MASSQL;Password=sqldatabasecis477!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string insert = "insert into users(userId,username,password) VALUES(@userId, @username, @password)";
            
            using (SqlCommand cmd = new SqlCommand(insert, sqlCon))
            {
                //getting the max PK for the table 
                string pkcheck = "Select max(userId) from users";
                SqlCommand cmd1 = new SqlCommand(pkcheck, sqlCon);
                sqlCon.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    int readReturn;
                    if (reader == null)
                    {
                        readReturn = Convert.ToInt32(reader[0]);
                        cmd.Parameters.AddWithValue("@userId", readReturn + 1);
                    }
                    else
                    {
                        readReturn = Convert.ToInt32(reader[0]);
                        cmd.Parameters.AddWithValue("@userId", readReturn + 1);
                    }
                }
                //closing the connection to the data base 
                sqlCon.Close();
                //getting the date and time 
                DateTime dateTime = DateTime.Now;
                //adding all current vars to the data base 
                cmd.Parameters.AddWithValue("@username", userNameTxtBox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", pwdTxtBox.Text.Trim());
                
                sqlCon.Open();
                //excuting the command 
                int result = cmd.ExecuteNonQuery();
                sqlCon.Close();
            
            }
            
            Sensor sensor = new Sensor();
            this.Close();
        }
    }
}
