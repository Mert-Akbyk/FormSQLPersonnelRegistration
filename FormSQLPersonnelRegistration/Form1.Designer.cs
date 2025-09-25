namespace FormSQLPersonnelRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtPersonelID = new TextBox();
            TxtPersonelName = new TextBox();
            TxtPersonelSurname = new TextBox();
            TxtPersonelJob = new TextBox();
            MskMoney = new MaskedTextBox();
            CmbCity = new ComboBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnExit = new Button();
            BtnStatistic = new Button();
            BtnClear = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnSave = new Button();
            BtnList = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtPersonelID
            // 
            TxtPersonelID.Location = new Point(177, 33);
            TxtPersonelID.Name = "TxtPersonelID";
            TxtPersonelID.Size = new Size(134, 30);
            TxtPersonelID.TabIndex = 0;
            // 
            // TxtPersonelName
            // 
            TxtPersonelName.Location = new Point(177, 65);
            TxtPersonelName.Name = "TxtPersonelName";
            TxtPersonelName.Size = new Size(134, 30);
            TxtPersonelName.TabIndex = 1;
            // 
            // TxtPersonelSurname
            // 
            TxtPersonelSurname.Location = new Point(177, 98);
            TxtPersonelSurname.Name = "TxtPersonelSurname";
            TxtPersonelSurname.Size = new Size(134, 30);
            TxtPersonelSurname.TabIndex = 2;
            // 
            // TxtPersonelJob
            // 
            TxtPersonelJob.Location = new Point(177, 197);
            TxtPersonelJob.Name = "TxtPersonelJob";
            TxtPersonelJob.Size = new Size(134, 30);
            TxtPersonelJob.TabIndex = 6;
            // 
            // MskMoney
            // 
            MskMoney.Location = new Point(177, 230);
            MskMoney.Name = "MskMoney";
            MskMoney.Size = new Size(134, 30);
            MskMoney.TabIndex = 7;
            // 
            // CmbCity
            // 
            CmbCity.FormattingEnabled = true;
            CmbCity.Location = new Point(177, 130);
            CmbCity.Name = "CmbCity";
            CmbCity.Size = new Size(134, 31);
            CmbCity.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtPersonelID);
            groupBox1.Controls.Add(MskMoney);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtPersonelName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtPersonelJob);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CmbCity);
            groupBox1.Controls.Add(TxtPersonelSurname);
            groupBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 274);
            groupBox1.TabIndex = 100;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label7.Location = new Point(110, 230);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 14;
            label7.Text = "Maaş :";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            radioButton2.Location = new Point(235, 163);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 27);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bekar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            radioButton1.Location = new Point(177, 163);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 27);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evli";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label6.Location = new Point(97, 198);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 11;
            label6.Text = "Meslek :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label5.Location = new Point(63, 165);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 10;
            label5.Text = "Medeni Hal :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label4.Location = new Point(113, 132);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 9;
            label4.Text = "Şehir :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label3.Location = new Point(101, 100);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 8;
            label3.Text = "Soyadı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label2.Location = new Point(125, 66);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 7;
            label2.Text = "Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label1.Location = new Point(133, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 6;
            label1.Text = "ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnExit);
            groupBox2.Controls.Add(BtnStatistic);
            groupBox2.Controls.Add(BtnClear);
            groupBox2.Controls.Add(BtnUpdate);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnSave);
            groupBox2.Controls.Add(BtnList);
            groupBox2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(434, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 274);
            groupBox2.TabIndex = 101;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler:";
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnExit.Location = new Point(93, 228);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(94, 40);
            BtnExit.TabIndex = 14;
            BtnExit.Text = "Çıkış";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnStatistic
            // 
            BtnStatistic.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnStatistic.Location = new Point(161, 178);
            BtnStatistic.Name = "BtnStatistic";
            BtnStatistic.Size = new Size(94, 40);
            BtnStatistic.TabIndex = 13;
            BtnStatistic.Text = "İstatistik";
            BtnStatistic.UseVisualStyleBackColor = true;
            BtnStatistic.Click += BtnStatistic_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnClear.Location = new Point(161, 115);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 40);
            BtnClear.TabIndex = 12;
            BtnClear.Text = "Temizle";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnUpdate.Location = new Point(20, 178);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 40);
            BtnUpdate.TabIndex = 10;
            BtnUpdate.Text = "Güncelle";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnDelete.Location = new Point(161, 56);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 40);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "Sil";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnSave.Location = new Point(20, 115);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 40);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Kaydet";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnList
            // 
            BtnList.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            BtnList.Location = new Point(20, 56);
            BtnList.Name = "BtnList";
            BtnList.Size = new Size(94, 42);
            BtnList.TabIndex = 8;
            BtnList.Text = "Listele";
            BtnList.UseVisualStyleBackColor = true;
            BtnList.Click += BtnList_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(12, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(947, 207);
            groupBox3.TabIndex = 102;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıtlar:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 178);
            dataGridView1.TabIndex = 200;
            dataGridView1.CellContentClick += dataGridView1_CellDoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(747, 242);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(969, 499);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Personel Kayıt İşlemleri ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPersonelID;
        private TextBox TxtPersonelName;
        private TextBox TxtPersonelSurname;
        private TextBox TxtPersonelJob;
        private MaskedTextBox MskMoney;
        private ComboBox CmbCity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnStatistic;
        private Button BtnClear;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnSave;
        private Button BtnList;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private Button BtnExit;
    }
}
