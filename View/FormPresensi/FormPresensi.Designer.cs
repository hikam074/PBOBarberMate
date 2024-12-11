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
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).BeginInit();
            SuspendLayout();
            // 
            // lblPresensi
            // 
            lblPresensi.AutoSize = true;
            lblPresensi.BackColor = Color.FromArgb(44, 62, 80);
            lblPresensi.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
            lblPresensi.ForeColor = Color.White;
            lblPresensi.Location = new Point(295, 46);
            lblPresensi.Name = "lblPresensi";
            lblPresensi.Size = new Size(205, 41);
            lblPresensi.TabIndex = 0;
            lblPresensi.Text = "Jadwal Shift";
            lblPresensi.Click += lblPresensi_Click;
            // 
            // dgvPresensi
            // 
            dgvPresensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresensi.Location = new Point(186, 112);
            dgvPresensi.Name = "dgvPresensi";
            dgvPresensi.RowHeadersWidth = 51;
            dgvPresensi.Size = new Size(428, 195);
            dgvPresensi.TabIndex = 1;
            dgvPresensi.CellContentClick += dgvPresensi_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.White;
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(174, 348);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormPresensi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(dgvPresensi);
            Controls.Add(lblPresensi);
            ForeColor = Color.White;
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
        private Button btnKembali;
    }
}