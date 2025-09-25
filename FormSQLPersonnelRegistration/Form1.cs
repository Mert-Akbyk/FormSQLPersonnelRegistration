namespace FormSQLPersonnelRegistration
{
    using System.Data;
    using System.Drawing;
    using System.Reflection.Emit;
    using System.Windows.Forms;
    // Install-Package Microsoft.Data.SqlClient .Net Core için NuGet indirilmesi gerekli.
    using Microsoft.Data.SqlClient;
    using static System.ComponentModel.Design.ObjectSelectorEditor;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

    public partial class Form1 : Form
    {
        string connectionString = " Data Source=EFE-AKBIYIK\\SQLEXPRESS;Initial Catalog=Staff_Data_Base;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        void clear()
        {
            TxtPersonelID.Text = "";
            TxtPersonelName.Text = "";
            TxtPersonelSurname.Text = "";
            CmbCity.Text = "";
            MskMoney.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtPersonelJob.Text = "";
            TxtPersonelName.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Tbl_Staff ORDER BY Staff_ID ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Tbl_Staff ORDER BY Staff_ID ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection contact = new SqlConnection(connectionString))
            {
                contact.Open();
                SqlCommand save = new SqlCommand("insert into Tbl_Staff (Staff_Name,Staff_Surname,Staff_City,Staff_Money,Staff_Info,Staff_Job) values (@s1,@s2,@s3,@s4,@s5,@s6)", contact);
                save.Parameters.AddWithValue("@s1", TxtPersonelName.Text);
                save.Parameters.AddWithValue("@s2", TxtPersonelSurname.Text);
                save.Parameters.AddWithValue("@s3", CmbCity.Text);
                save.Parameters.AddWithValue("@s4", MskMoney.Text);
                save.Parameters.AddWithValue("@s5", label8.Text);
                save.Parameters.AddWithValue("@s6", TxtPersonelJob.Text);
                save.ExecuteNonQuery();
                MessageBox.Show("Personel Eklendi..!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choice = dataGridView1.SelectedCells[0].RowIndex;
            TxtPersonelID.Text = dataGridView1.Rows[choice].Cells[0].Value.ToString();
            TxtPersonelName.Text = dataGridView1.Rows[choice].Cells[1].Value.ToString();
            TxtPersonelSurname.Text = dataGridView1.Rows[choice].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[choice].Cells[3].Value.ToString();
            MskMoney.Text = dataGridView1.Rows[choice].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[choice].Cells[5].Value.ToString();
            TxtPersonelJob.Text = dataGridView1.Rows[choice].Cells[6].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection datadel = new SqlConnection(connectionString))
            {
                datadel.Open();
                SqlCommand del = new SqlCommand("delete from Tbl_Staff where Staff_ID=@k1", datadel);
                del.Parameters.AddWithValue("@k1", TxtPersonelID.Text);
                del.ExecuteNonQuery();
                MessageBox.Show("Kayýt Silindi..!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection dataup = new SqlConnection(connectionString))
            {
                dataup.Open();
                SqlCommand up = new SqlCommand("update Tbl_Staff set Staff_Name=@u1,Staff_Surname=@u2,Staff_City=@u3,Staff_Money=@u4,Staff_Info=@u5,Staff_Job=@u6 where Staff_ID=@u7", dataup);
                up.Parameters.AddWithValue("@u1", TxtPersonelName.Text);
                up.Parameters.AddWithValue("@u2", TxtPersonelSurname.Text);
                up.Parameters.AddWithValue("@u3", CmbCity.Text);
                up.Parameters.AddWithValue("@u4", MskMoney.Text);
                up.Parameters.AddWithValue("@u5", label8.Text);
                up.Parameters.AddWithValue("@u6", TxtPersonelJob.Text);
                up.Parameters.AddWithValue("@u7", TxtPersonelID.Text);
                up.ExecuteNonQuery();
                MessageBox.Show("Kayýt Güncellendi..!");

            }
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            FrmÝstatistic fi = new FrmÝstatistic();
            fi.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

