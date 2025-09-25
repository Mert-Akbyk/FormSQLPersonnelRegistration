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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormSQLPersonnelRegistration
{
    public partial class Frmİstatistic : Form
    {
        public Frmİstatistic()
        {
            InitializeComponent();
        }

        string connectionString = " Data Source=EFE-AKBIYIK\\SQLEXPRESS;Initial Catalog=Staff_Data_Base;Integrated Security=True;Encrypt=True;Trust Server Certificate=True ";

        private void Frmİstatistic_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Total Staff
                SqlCommand cmd = new SqlCommand("Select Count (*) from Tbl_Staff", conn);
                int total = (int)cmd.ExecuteScalar();
                totalstaffnu.Text = total.ToString();

                //Married Staff
                SqlCommand cmd1 = new SqlCommand("Select Count (*) from Tbl_Staff where Staff_Info = 1", conn);
                int nu1 = (int)cmd1.ExecuteScalar();
                marriedstaffnu.Text = nu1.ToString();

                //Single Staff
                SqlCommand cmd2 = new SqlCommand("Select Count (*) from Tbl_Staff where Staff_Info = 0", conn);
                int nu2 = (int)cmd2.ExecuteScalar();
                singlestaffnu.Text = nu2.ToString();

                //Dif City
                SqlCommand cmd3 = new SqlCommand("Select Count(DISTINCT Staff_City) from Tbl_Staff", conn);
                int difc = (int)cmd3.ExecuteScalar();
                diffcitynu.Text = difc.ToString();

                //Total Salary
                SqlCommand cmd4 = new SqlCommand("Select Sum(Staff_Money) from Tbl_Staff", conn);
                int sum = (int)cmd4.ExecuteScalar();
                totalsalary.Text = sum.ToString();

                //Avarage Slary
                SqlCommand cmd5 = new SqlCommand("Select AVG(Staff_Money) from Tbl_Staff", conn);
                int avg = (int)cmd5.ExecuteScalar();
                averagesalary.Text = avg.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}