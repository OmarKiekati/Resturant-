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
    public partial class admHome : Form
    {
      
        public admHome()
        {
            InitializeComponent();
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            addUser form= new addUser();
            form.Show();
            this.Close();
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            addCategory form = new addCategory();
            form.Show();
            this.Close();
        }
    }
}
