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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblJadwalShift.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold);
            lblJadwalShift.ForeColor = Color.FromArgb(44, 62, 80);
            lblJadwalShift.Location = new Point(290, 30);
            lblJadwalShift.Name = "lblJadwalShift";
            lblJadwalShift.Size = new Size(394, 58);
            lblJadwalShift.TabIndex = 0;
            lblJadwalShift.Text = "Jadwal Shift Karyawan";
            // 
            // dgvJadwalShift
            // 
            dgvJadwalShift.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJadwalShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJadwalShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvJadwalShift.DefaultCellStyle = dataGridViewCellStyle2;
            dgvJadwalShift.GridColor = Color.FromArgb(80, 61, 44);
            dgvJadwalShift.Location = new Point(75, 125);
            dgvJadwalShift.Margin = new Padding(3, 2, 3, 2);
            dgvJadwalShift.Name = "dgvJadwalShift";
            dgvJadwalShift.RowHeadersWidth = 51;
            dgvJadwalShift.Size = new Size(800, 324);
            dgvJadwalShift.TabIndex = 1;
            dgvJadwalShift.CellContentClick += dgvJadwalShift_CellContentClick;
            // 
            // btnAddJadwal
            // 
            btnAddJadwal.BackColor = Color.FromArgb(80, 61, 44);
            btnAddJadwal.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAddJadwal.ForeColor = Color.White;
            btnAddJadwal.Location = new Point(800, 82);
            btnAddJadwal.Margin = new Padding(3, 2, 3, 2);
            btnAddJadwal.Name = "btnAddJadwal";
            btnAddJadwal.Size = new Size(75, 39);
            btnAddJadwal.TabIndex = 2;
            btnAddJadwal.Text = "Tambah";
            btnAddJadwal.UseVisualStyleBackColor = false;
            btnAddJadwal.Click += btnAddJadwal_Click;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.Left;
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(15, 15);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(944, 501);
            Controls.Add(btnKembali);
            Controls.Add(btnAddJadwal);
            Controls.Add(dgvJadwalShift);
            Controls.Add(lblJadwalShift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormShift";
            StartPosition = FormStartPosition.CenterScreen;
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