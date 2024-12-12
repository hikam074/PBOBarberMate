namespace PBOBarberMate.View.FormPembayaran
{
    partial class FormLihatPembayaranUntukUlasan
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
            dgvDataPembayaran = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDataPembayaran).BeginInit();
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
            lblTitle.Location = new Point(159, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(485, 58);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Riwayat Kunjungan";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDataPembayaran
            // 
            dgvDataPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPembayaran.Location = new Point(26, 102);
            dgvDataPembayaran.Name = "dgvDataPembayaran";
            dgvDataPembayaran.Size = new Size(748, 324);
            dgvDataPembayaran.TabIndex = 10;
            dgvDataPembayaran.CellContentClick += dgvDataPembayaran_CellContentClick;
            // 
            // FormLihatPembayaranUntukUlasan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(lblTitle);
            Controls.Add(dgvDataPembayaran);
            Name = "FormLihatPembayaranUntukUlasan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLihatPembayaran";
            ((System.ComponentModel.ISupportInitialize)dgvDataPembayaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        public Label lblTitle;
        private DataGridView dgvDataPembayaran;
    }
}