namespace PBOBarberMate.View.Layanan
{
    partial class LayananUC
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
            dgvLayanan = new DataGridView();
            lblLayanan = new Label();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLayanan).BeginInit();
            SuspendLayout();
            // 
            // dgvLayanan
            // 
            dgvLayanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLayanan.BackgroundColor = SystemColors.Control;
            dgvLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLayanan.Location = new Point(100, 100);
            dgvLayanan.Margin = new Padding(2);
            dgvLayanan.Name = "dgvLayanan";
            dgvLayanan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvLayanan.Size = new Size(544, 300);
            dgvLayanan.TabIndex = 0;
            dgvLayanan.CellContentClick += dgvLayanan_CellContentClick;
            // 
            // lblLayanan
            // 
            lblLayanan.AutoSize = true;
            lblLayanan.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLayanan.Location = new Point(100, 40);
            lblLayanan.Margin = new Padding(2, 0, 2, 0);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(201, 39);
            lblLayanan.TabIndex = 1;
            lblLayanan.Text = "Layanan Tersedia";
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambah.BackColor = SystemColors.Control;
            btnTambah.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnTambah.ForeColor = Color.FromArgb(44, 62, 80);
            btnTambah.Location = new Point(569, 40);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 39);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // LayananUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnTambah);
            Controls.Add(lblLayanan);
            Controls.Add(dgvLayanan);
            Margin = new Padding(2);
            Name = "LayananUC";
            Size = new Size(744, 451);
            Load += FormLayanan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLayanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLayanan;
        private Label lblLayanan;
        private Button btnTambah;
    }
}