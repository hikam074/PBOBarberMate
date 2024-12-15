namespace PBOBarberMate.View.FormPembayaran
{
    partial class FormLihatPembayaran
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
            lblTitle = new Label();
            dgvDataReservasi = new DataGridView();
            gbxIncomeToday = new GroupBox();
            lblIncomeToday = new Label();
            gbxPelangganToday = new GroupBox();
            lblHeadingPelangganToday = new Label();
            gbxIncomeMonth = new GroupBox();
            lblHeadingIncomeMonth = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).BeginInit();
            gbxIncomeToday.SuspendLayout();
            gbxPelangganToday.SuspendLayout();
            gbxIncomeMonth.SuspendLayout();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.Control;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(26, 24);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 12;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(184, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(485, 58);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Keuangan Barbershop";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDataReservasi
            // 
            dgvDataReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataReservasi.Location = new Point(54, 297);
            dgvDataReservasi.Name = "dgvDataReservasi";
            dgvDataReservasi.Size = new Size(720, 129);
            dgvDataReservasi.TabIndex = 10;
            // 
            // gbxIncomeToday
            // 
            gbxIncomeToday.Controls.Add(lblIncomeToday);
            gbxIncomeToday.Location = new Point(62, 122);
            gbxIncomeToday.Name = "gbxIncomeToday";
            gbxIncomeToday.Size = new Size(200, 100);
            gbxIncomeToday.TabIndex = 13;
            gbxIncomeToday.TabStop = false;
            // 
            // lblIncomeToday
            // 
            lblIncomeToday.AutoSize = true;
            lblIncomeToday.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblIncomeToday.Location = new Point(11, 19);
            lblIncomeToday.Name = "lblIncomeToday";
            lblIncomeToday.Size = new Size(104, 18);
            lblIncomeToday.TabIndex = 0;
            lblIncomeToday.Text = "Pendapatan hari ini";
            // 
            // gbxPelangganToday
            // 
            gbxPelangganToday.Controls.Add(lblHeadingPelangganToday);
            gbxPelangganToday.Location = new Point(320, 122);
            gbxPelangganToday.Name = "gbxPelangganToday";
            gbxPelangganToday.Size = new Size(200, 100);
            gbxPelangganToday.TabIndex = 14;
            gbxPelangganToday.TabStop = false;
            // 
            // lblHeadingPelangganToday
            // 
            lblHeadingPelangganToday.AutoSize = true;
            lblHeadingPelangganToday.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblHeadingPelangganToday.Location = new Point(10, 20);
            lblHeadingPelangganToday.Name = "lblHeadingPelangganToday";
            lblHeadingPelangganToday.Size = new Size(103, 18);
            lblHeadingPelangganToday.TabIndex = 0;
            lblHeadingPelangganToday.Text = "Pengunjung hari ini";
            // 
            // gbxIncomeMonth
            // 
            gbxIncomeMonth.Controls.Add(lblHeadingIncomeMonth);
            gbxIncomeMonth.Location = new Point(574, 122);
            gbxIncomeMonth.Name = "gbxIncomeMonth";
            gbxIncomeMonth.Size = new Size(200, 100);
            gbxIncomeMonth.TabIndex = 15;
            gbxIncomeMonth.TabStop = false;
            // 
            // lblHeadingIncomeMonth
            // 
            lblHeadingIncomeMonth.AutoSize = true;
            lblHeadingIncomeMonth.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblHeadingIncomeMonth.Location = new Point(10, 20);
            lblHeadingIncomeMonth.Name = "lblHeadingIncomeMonth";
            lblHeadingIncomeMonth.Size = new Size(105, 18);
            lblHeadingIncomeMonth.TabIndex = 0;
            lblHeadingIncomeMonth.Text = "Pendaptan bulan ini";
            // 
            // FormLihatPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxIncomeMonth);
            Controls.Add(gbxPelangganToday);
            Controls.Add(gbxIncomeToday);
            Controls.Add(btnKembali);
            Controls.Add(lblTitle);
            Controls.Add(dgvDataReservasi);
            Name = "FormLihatPembayaran";
            Text = "FormLihatPembayaran";
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).EndInit();
            gbxIncomeToday.ResumeLayout(false);
            gbxIncomeToday.PerformLayout();
            gbxPelangganToday.ResumeLayout(false);
            gbxPelangganToday.PerformLayout();
            gbxIncomeMonth.ResumeLayout(false);
            gbxIncomeMonth.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        public Label lblTitle;
        private DataGridView dgvDataReservasi;
        private GroupBox gbxIncomeToday;
        private GroupBox gbxPelangganToday;
        private GroupBox gbxIncomeMonth;
        private Label lblIncomeToday;
        private Label lblHeadingPelangganToday;
        private Label lblHeadingIncomeMonth;
    }
}