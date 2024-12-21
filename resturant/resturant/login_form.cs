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
using Microsoft.SqlServer.Server;

namespace resturant
{
    public partial class login_form : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public login_form()
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\resturant\\resturant\\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(conString);
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
            if(conn.State != ConnectionState.Open) conn.Open();

            string user = user_name.Text;
            string pass = password.Text;
            string sql = string.Format("select role from Users where user_name= @user and password=@pass");
            cmd= new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue ("@pass", pass);
            object res=cmd.ExecuteScalar();
            if (res != null)
            {
                MessageBox.Show("done");
                string role=res.ToString();
                if(role == "ADMIN")
                {
                    admHome Home =new admHome();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    empHome Home = new empHome();
                    Home.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("user not found");

            }
            conn.Close();
        }

        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}


