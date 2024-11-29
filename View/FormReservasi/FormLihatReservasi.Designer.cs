namespace PBOBarberMate.View.FormReservasi
{
    partial class FormLihatReservasi
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
            dgvDataReservasi = new DataGridView();
            lblTitle = new Label();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).BeginInit();
            SuspendLayout();
            // 
            // dgvDataReservasi
            // 
            dgvDataReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataReservasi.Location = new Point(40, 104);
            dgvDataReservasi.Name = "dgvDataReservasi";
            dgvDataReservasi.Size = new Size(720, 310);
            dgvDataReservasi.TabIndex = 1;
            dgvDataReservasi.CellContentClick += dgvDataReservasi_CellContentClick;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(170, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(485, 58);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Reservasi && Kunjungan Anda";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = SystemColors.Control;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(12, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 9;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormLihatReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(lblTitle);
            Controls.Add(dgvDataReservasi);
            Name = "FormLihatReservasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLihatReservasi";
            Load += FormLihatReservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDataReservasi;
        public Label lblTitle;
        private Button btnKembali;
    }
}