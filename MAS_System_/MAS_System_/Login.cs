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

            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MAS_System.mdf;Integrated Security=True;Connect Timeout=30");
            //string qurey
            string query = "SELECT * from dbo.[user] WHERE username='" + userNameTxt.Text.Trim() + "' AND password='" + passwrdTxt.Text.Trim() + "'";
            //data adapter
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                DateTime dateTime = DateTime.Now;
                string insert = "Insert into dbo.[loginLog]([username],[datetime])VAULES('" + userNameTxt.Text + "','" + dateTime.ToString() + "')'";
                SqlDataAdapter adapter = new SqlDataAdapter(insert,sqlCon);
                /* 
                 
                 SqlDataAdapter logininsert = new SqlDataAdapter(insert, sqlCon);
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
