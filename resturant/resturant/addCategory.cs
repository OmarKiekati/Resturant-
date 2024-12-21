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
    public partial class addCategory : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public addCategory()
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\resturant\\resturant\\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(conString);
            InitializeComponent();
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            string pname = name.Text;
            string sql =string.Format("insert into categories (name) values('{0}')",pname);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("category added successfully");
            conn.Close();
        }
    }
}
