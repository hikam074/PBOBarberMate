namespace PBOBarberMate.View.Presensi
{
    partial class PresensiHistoryUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblPresensi = new Label();
            dgvPresensi = new DataGridView();
            lblNamaKaryawan = new Label();
            lblTanggalRange = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).BeginInit();
            SuspendLayout();
            // 
            // lblPresensi
            // 
            lblPresensi.AutoSize = true;
            lblPresensi.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblPresensi.ForeColor = Color.Black;
            lblPresensi.Location = new Point(100, 40);
            lblPresensi.Name = "lblPresensi";
            lblPresensi.Size = new Size(274, 39);
            lblPresensi.TabIndex = 0;
            lblPresensi.Text = "Riwayat Kehadiran Anda";
            // 
            // dgvPresensi
            // 
            dgvPresensi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPresensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresensi.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPresensi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPresensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPresensi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPresensi.Location = new Point(100, 100);
            dgvPresensi.Margin = new Padding(3, 2, 3, 2);
            dgvPresensi.Name = "dgvPresensi";
            dgvPresensi.RowHeadersWidth = 51;
            dgvPresensi.Size = new Size(544, 300);
            dgvPresensi.TabIndex = 1;
            // 
            // lblNamaKaryawan
            // 
            lblNamaKaryawan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNamaKaryawan.AutoSize = true;
            lblNamaKaryawan.ForeColor = Color.Black;
            lblNamaKaryawan.Location = new Point(551, 60);
            lblNamaKaryawan.Name = "lblNamaKaryawan";
            lblNamaKaryawan.Size = new Size(93, 15);
            lblNamaKaryawan.TabIndex = 2;
            lblNamaKaryawan.Text = "Nama Karyawan";
            lblNamaKaryawan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggalRange
            // 
            lblTanggalRange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggalRange.AutoSize = true;
            lblTanggalRange.ForeColor = Color.Black;
            lblTanggalRange.Location = new Point(530, 45);
            lblTanggalRange.Name = "lblTanggalRange";
            lblTanggalRange.Size = new Size(114, 15);
            lblTanggalRange.TabIndex = 3;
            lblTanggalRange.Text = "Tanggal awal - Akhir";
            lblTanggalRange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PresensiHistoryUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTanggalRange);
            Controls.Add(lblNamaKaryawan);
            Controls.Add(dgvPresensi);
            Controls.Add(lblPresensi);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PresensiHistoryUC";
            Size = new Size(744, 451);
            Load += PresensiHistoryUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPresensi;
        private DataGridView dgvPresensi;
        private Label lblNamaKaryawan;
        private Label lblTanggalRange;
    }
}