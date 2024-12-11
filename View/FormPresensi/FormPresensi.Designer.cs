namespace PBOBarberMate.View.FormPresensi
{
    partial class FormPresensi
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
            lblPresensi = new Label();
            dgvPresensi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).BeginInit();
            SuspendLayout();
            // 
            // lblPresensi
            // 
            lblPresensi.AutoSize = true;
            lblPresensi.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
            lblPresensi.ForeColor = Color.White;
            lblPresensi.Location = new Point(244, 43);
            lblPresensi.Name = "lblPresensi";
            lblPresensi.Size = new Size(307, 41);
            lblPresensi.TabIndex = 0;
            lblPresensi.Text = "Presensi Sekarang";
            lblPresensi.Click += lblPresensi_Click;
            // 
            // dgvPresensi
            // 
            dgvPresensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresensi.Location = new Point(104, 101);
            dgvPresensi.Name = "dgvPresensi";
            dgvPresensi.RowHeadersWidth = 51;
            dgvPresensi.Size = new Size(591, 261);
            dgvPresensi.TabIndex = 1;
            dgvPresensi.CellContentClick += dgvPresensi_CellContentClick;
            // 
            // FormPresensi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPresensi);
            Controls.Add(lblPresensi);
            ForeColor = Color.FromArgb(44, 62, 80);
            Name = "FormPresensi";
            Text = "FormPresensi";
            Load += FormPresensi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPresensi;
        private DataGridView dgvPresensi;
    }
}