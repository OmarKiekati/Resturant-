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
    public partial class addProduct : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public addProduct()
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\resturant\\resturant\\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(conString);

            InitializeComponent();
        }

        private void addPro_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            string prName=name.Text;
            string pPrice=price.Text;
            string ing=ingrediants.Text;
            int cat = categories.SelectedIndex;
            string sql = string.Format("insert into products (name,price,ingrediants,category_id) values('{0}')", prName,pPrice,ing,cat);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("product added successfully");
            conn.Close();
        }

        
    }
}
