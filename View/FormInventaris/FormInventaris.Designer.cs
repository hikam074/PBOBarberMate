namespace PBOBarberMate.View.FormInventaris
{
    partial class FormInventaris
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
            btnTambah = new Button();
            lblInventaris = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.Control;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(11, 451);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.Control;
            btnTambah.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnTambah.ForeColor = Color.FromArgb(44, 62, 80);
            btnTambah.Location = new Point(858, 451);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 39);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblInventaris
            // 
            lblInventaris.AutoSize = true;
            lblInventaris.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold);
            lblInventaris.Location = new Point(326, 28);
            lblInventaris.Margin = new Padding(2, 0, 2, 0);
            lblInventaris.Name = "lblInventaris";
            lblInventaris.Size = new Size(288, 58);
            lblInventaris.TabIndex = 5;
            lblInventaris.Text = "List Stok Barang";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 105);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(885, 342);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormInventaris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(lblInventaris);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "FormInventaris";
            Text = "FormInventaris";
            Load += FormInventaris_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Button btnTambah;
        private Label lblInventaris;
        private DataGridView dataGridView1;
    }
}