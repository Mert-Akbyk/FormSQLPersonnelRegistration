using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FormSQLPersonnelRegistration
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }
       
        string connectionString = " Data Source=EFE-AKBIYIK\\SQLEXPRESS;Initial Catalog=Staff_Data_Base;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection login = new SqlConnection(connectionString))
            {
                login.Open();
                SqlCommand log = new SqlCommand("select * from Tbl_Login where UserName = @l1 and UserPass = @l2 ", login);
                log.Parameters.AddWithValue("@l1", TxtUserName.Text);
                log.Parameters.AddWithValue("@l2", TxtUserPass.Text);
               
                using (SqlDataReader dr = log.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre..!");
                    }   
                }
            }

        }
    }
}
