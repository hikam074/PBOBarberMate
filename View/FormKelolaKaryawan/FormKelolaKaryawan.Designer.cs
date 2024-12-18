namespace PBOBarberMate.View.FormKelolaKaryawan
{
    partial class FormKelolaKaryawan 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKembali = new Button();
            dataGridViewKelolaKaryawan = new DataGridView();
            lblKelolaKaryawan = new Label();
            button1 = new Button();
            label1 = new Label();
            DataGridViewDaftarKaryawan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDaftarKaryawan).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(26, 405);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(78, 20);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridViewKelolaKaryawan
            // 
            dataGridViewKelolaKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKelolaKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKelolaKaryawan.Location = new Point(26, 90);
            dataGridViewKelolaKaryawan.Margin = new Padding(2);
            dataGridViewKelolaKaryawan.Name = "dataGridViewKelolaKaryawan";
            dataGridViewKelolaKaryawan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewKelolaKaryawan.Size = new Size(446, 301);
            dataGridViewKelolaKaryawan.TabIndex = 5;
            dataGridViewKelolaKaryawan.CellContentClick += dataGridViewKelolaKaryawan_CellContentClick;
            // 
            // lblKelolaKaryawan
            // 
            lblKelolaKaryawan.AutoSize = true;
            lblKelolaKaryawan.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKelolaKaryawan.Location = new Point(117, 38);
            lblKelolaKaryawan.Margin = new Padding(2, 0, 2, 0);
            lblKelolaKaryawan.Name = "lblKelolaKaryawan";
            lblKelolaKaryawan.Size = new Size(258, 39);
            lblKelolaKaryawan.TabIndex = 7;
            lblKelolaKaryawan.Text = "Daftar Hadir Karyawan";
            // 
            // button1
            // 
            button1.Location = new Point(703, 405);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 20);
            button1.TabIndex = 8;
            button1.Text = "TAMBAH KARYAWAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(572, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 39);
            label1.TabIndex = 9;
            label1.Text = "Daftar Karyawan";
            // 
            // DataGridViewDaftarKaryawan
            // 
            DataGridViewDaftarKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewDaftarKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDaftarKaryawan.Location = new Point(498, 90);
            DataGridViewDaftarKaryawan.Margin = new Padding(2);
            DataGridViewDaftarKaryawan.Name = "DataGridViewDaftarKaryawan";
            DataGridViewDaftarKaryawan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewDaftarKaryawan.Size = new Size(349, 301);
            DataGridViewDaftarKaryawan.TabIndex = 10;
            DataGridViewDaftarKaryawan.CellContentClick += DataGridViewDaftarKaryawan_CellContentClick;
            // 
            // FormKelolaKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 450);
            Controls.Add(DataGridViewDaftarKaryawan);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblKelolaKaryawan);
            Controls.Add(dataGridViewKelolaKaryawan);
            Controls.Add(btnKembali);
            Name = "FormKelolaKaryawan";
            Text = "KelolaKaryawan";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDaftarKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private DataGridView dataGridViewKelolaKaryawan;
        private Label lblKelolaKaryawan;
        private Button button1;
        private Label label1;
        private DataGridView DataGridViewDaftarKaryawan;
    }
}
