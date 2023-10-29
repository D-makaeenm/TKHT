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

namespace TKHT
{
    public partial class change_pw : Form
    {
        public change_pw()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpw = oldpass.Text;
            string newpw = newpass.Text;
            string cfpw = confirm.Text;
            if (xacminhmkcu(oldpw) && xacminhmkmoi(newpw, cfpw))
            {
                if (xacminhmkcu(newpw))
                {
                    MessageBox.Show("MK da thay doi");
                }
                else
                {
                    MessageBox.Show("Mk chua doi dc");
                }
            }
        }
        private bool xacminhmkcu(string oldpw)
        {
            string constring = @"Server=DUYVPRO;Database=DA_PTTKHT;User Id=sa;Password=makaeenm1;";
            using(SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                string query = "Select ";
            }
            return true;
        }
        private bool xacminhmkmoi(string newpw, string cfpw)
        {
            return true;
        }
        private bool change_pw_in_db(string newpw)
        {
            return false;
        }
    }
}
