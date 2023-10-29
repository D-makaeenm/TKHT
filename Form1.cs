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
using Microsoft.SqlServer;


namespace TKHT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Server=DUYVPRO;Database=DA_PTTKHT;User Id=sa;Password=makaeenm1;";
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(chuoiketnoi);
            SqlCommand cmd = new SqlCommand("select * from logins where tk=@tk and mk=@mk",con);
            cmd.Parameters.AddWithValue("@tk", textBox1.Text);
            cmd.Parameters.AddWithValue("@mk", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap thanh cong!");
                formdangnhap formdn = new formdangnhap();
                formdn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay dien dung tai khoan hoac mat khau");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}