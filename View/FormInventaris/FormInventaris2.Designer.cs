namespace PBOBarberMate.View.FormInventaris
{
    partial class FormInventaris2
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
            btnKembali.Location = new Point(12, 639);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(111, 33);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1074, 639);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 33);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblInventaris
            // 
            lblInventaris.AutoSize = true;
            lblInventaris.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventaris.Location = new Point(475, 25);
            lblInventaris.Name = "lblInventaris";
            lblInventaris.Size = new Size(274, 58);
            lblInventaris.TabIndex = 5;
            lblInventaris.Text = "List Stok Barang";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1173, 502);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormInventaris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 695);
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(lblInventaris);
            Controls.Add(dataGridView1);
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