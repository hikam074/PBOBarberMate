namespace PBOBarberMate.Presentation.Views.Jadwal
{
    partial class JadwalUC
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalUC));
            lblShift = new Label();
            dgvJadwal = new DataGridView();
            lblKiat = new Label();
            pictbxAdd = new PictureBox();
            btnPresensi = new Button();
            pictbxAddHov = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            SuspendLayout();
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblShift.ForeColor = Color.Black;
            lblShift.Location = new Point(100, 40);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(204, 39);
            lblShift.TabIndex = 0;
            lblShift.Text = "Jadwal Karyawan";
            // 
            // dgvJadwal
            // 
            dgvJadwal.AllowUserToAddRows = false;
            dgvJadwal.AllowUserToDeleteRows = false;
            dgvJadwal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvJadwal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvJadwal.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvJadwal.DefaultCellStyle = dataGridViewCellStyle2;
            dgvJadwal.EnableHeadersVisualStyles = false;
            dgvJadwal.GridColor = Color.Black;
            dgvJadwal.Location = new Point(100, 100);
            dgvJadwal.Margin = new Padding(3, 2, 3, 2);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersVisible = false;
            dgvJadwal.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvJadwal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvJadwal.Size = new Size(544, 300);
            dgvJadwal.TabIndex = 1;
            dgvJadwal.CellClick += dgvJadwal_CellClick;
            dgvJadwal.CellFormatting += dgvJadwal_CellFormatting;
            // 
            // lblKiat
            // 
            lblKiat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKiat.AutoSize = true;
            lblKiat.ForeColor = Color.Gray;
            lblKiat.Location = new Point(342, 49);
            lblKiat.Margin = new Padding(0, 3, 0, 3);
            lblKiat.Name = "lblKiat";
            lblKiat.Size = new Size(302, 30);
            lblKiat.TabIndex = 2;
            lblKiat.Text = "Klik sel jadwal untuk mengubah status jadwal :\r\nTersedia, Sibuk (Sedang Bekerja / Tidak di Tempat), Libur\r\n";
            lblKiat.TextAlign = ContentAlignment.BottomRight;
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(515, 59);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 30;
            pictbxAdd.TabStop = false;
            // 
            // btnPresensi
            // 
            btnPresensi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPresensi.BackColor = SystemColors.Control;
            btnPresensi.Cursor = Cursors.Hand;
            btnPresensi.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnPresensi.ForeColor = Color.Black;
            btnPresensi.Location = new Point(506, 47);
            btnPresensi.Margin = new Padding(2);
            btnPresensi.Name = "btnPresensi";
            btnPresensi.Size = new Size(138, 39);
            btnPresensi.TabIndex = 29;
            btnPresensi.Text = "Presensi Sekarang!";
            btnPresensi.TextAlign = ContentAlignment.MiddleRight;
            btnPresensi.UseVisualStyleBackColor = false;
            btnPresensi.Click += btnPresensi_Click;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(515, 59);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 31;
            pictbxAddHov.TabStop = false;
            pictbxAddHov.Visible = false;
            // 
            // JadwalUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictbxAdd);
            Controls.Add(btnPresensi);
            Controls.Add(pictbxAddHov);
            Controls.Add(lblKiat);
            Controls.Add(dgvJadwal);
            Controls.Add(lblShift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JadwalUC";
            Size = new Size(744, 451);
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShift;
        private DataGridView dgvJadwal;
        private Label lblKiat;
        private PictureBox pictbxAdd;
        private Button btnPresensi;
        private PictureBox pictbxAddHov;
    }
}