namespace PBOBarberMate.View.FormShift
{
    partial class FormShift
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
            lblJadwalShift = new Label();
            dgvJadwalShift = new DataGridView();
            btnAddJadwal = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalShift).BeginInit();
            SuspendLayout();
            // 
            // lblJadwalShift
            // 
            lblJadwalShift.AutoSize = true;
            lblJadwalShift.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJadwalShift.Location = new Point(304, 21);
            lblJadwalShift.Name = "lblJadwalShift";
            lblJadwalShift.Size = new Size(146, 29);
            lblJadwalShift.TabIndex = 0;
            lblJadwalShift.Text = "Jadwal Shift";
            // 
            // dgvJadwalShift
            // 
            dgvJadwalShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalShift.Location = new Point(46, 62);
            dgvJadwalShift.Margin = new Padding(3, 2, 3, 2);
            dgvJadwalShift.Name = "dgvJadwalShift";
            dgvJadwalShift.RowHeadersWidth = 51;
            dgvJadwalShift.Size = new Size(680, 263);
            dgvJadwalShift.TabIndex = 1;
            dgvJadwalShift.CellContentClick += dgvJadwalShift_CellContentClick;
            // 
            // btnAddJadwal
            // 
            btnAddJadwal.Location = new Point(644, 338);
            btnAddJadwal.Margin = new Padding(3, 2, 3, 2);
            btnAddJadwal.Name = "btnAddJadwal";
            btnAddJadwal.Size = new Size(82, 22);
            btnAddJadwal.TabIndex = 2;
            btnAddJadwal.Text = "Tambah";
            btnAddJadwal.UseVisualStyleBackColor = true;
            btnAddJadwal.Click += btnAddJadwal_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(46, 338);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(82, 22);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 380);
            Controls.Add(btnKembali);
            Controls.Add(btnAddJadwal);
            Controls.Add(dgvJadwalShift);
            Controls.Add(lblJadwalShift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormShift";
            Text = "FormShift";
            Load += FormShift_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJadwalShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJadwalShift;
        private DataGridView dgvJadwalShift;
        private Button btnAddJadwal;
        private Button btnKembali;
    }
}