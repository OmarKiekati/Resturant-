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

namespace resturant
{
    public partial class addUser : Form

    {
        // conniction database
        SqlConnection conn;
        SqlCommand cmd;
        public addUser()
        {
            // conniction database
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\resturant\\resturant\\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(conString);
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //open conniction to database
            if (conn.State != ConnectionState.Open) conn.Open();
            string user = user_name.Text;
            string password=pass.Text;
            string role;
            if (ADMIN.Checked)
            {
                role = "ADMIN";
            }
            else
            role = "EMPLOYEE";
            string sql = string.Format("insert into users (user_name,password,role) values('{0}','{1}','{2}')",user,password,role);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("user added successfully");
            conn.Close();
        }
    }
}
