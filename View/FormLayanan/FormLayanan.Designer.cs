namespace PBOBarberMate.View
{
    partial class FormLayanan
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
            dataGridView1 = new DataGridView();
            lblLayanan = new Label();
            btnTambah = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 56);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(821, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // lblLayanan
            // 
            lblLayanan.AutoSize = true;
            lblLayanan.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLayanan.Location = new Point(361, 5);
            lblLayanan.Margin = new Padding(2, 0, 2, 0);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(149, 39);
            lblLayanan.TabIndex = 1;
            lblLayanan.Text = "List Layanan";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(768, 369);
            btnTambah.Margin = new Padding(2, 2, 2, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(78, 20);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(25, 369);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(78, 20);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormLayanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(872, 397);
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(lblLayanan);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLayanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLayanan";
            Load += FormLayanan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblLayanan;
        private Button btnTambah;
        private Button btnKembali;
    }
}