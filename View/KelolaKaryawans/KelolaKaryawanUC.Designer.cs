namespace PBOBarberMate.View.KelolaKaryawan
{
    partial class KelolaKaryawanUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaKaryawanUC));
            dgvKaryawan = new DataGridView();
            lblKelolaKaryawan = new Label();
            pictbxAdd = new PictureBox();
            btnTambah = new Button();
            pictbxAddHov = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            SuspendLayout();
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKaryawan.BackgroundColor = SystemColors.Control;
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.GridColor = Color.Black;
            dgvKaryawan.Location = new Point(100, 100);
            dgvKaryawan.Margin = new Padding(2);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvKaryawan.Size = new Size(544, 300);
            dgvKaryawan.TabIndex = 5;
            dgvKaryawan.CellContentClick += dgvKaryawan_CellContentClick;
            // 
            // lblKelolaKaryawan
            // 
            lblKelolaKaryawan.AutoSize = true;
            lblKelolaKaryawan.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblKelolaKaryawan.Location = new Point(100, 40);
            lblKelolaKaryawan.Margin = new Padding(2, 0, 2, 0);
            lblKelolaKaryawan.Name = "lblKelolaKaryawan";
            lblKelolaKaryawan.Size = new Size(182, 39);
            lblKelolaKaryawan.TabIndex = 7;
            lblKelolaKaryawan.Text = "Karyawan Anda";
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(578, 52);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 29;
            pictbxAdd.TabStop = false;
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambah.BackColor = SystemColors.Control;
            btnTambah.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnTambah.ForeColor = Color.Black;
            btnTambah.Location = new Point(569, 40);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 39);
            btnTambah.TabIndex = 28;
            btnTambah.Text = "Tambah";
            btnTambah.TextAlign = ContentAlignment.MiddleRight;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(578, 52);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 30;
            pictbxAddHov.TabStop = false;
            // 
            // KelolaKaryawanUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictbxAdd);
            Controls.Add(btnTambah);
            Controls.Add(pictbxAddHov);
            Controls.Add(lblKelolaKaryawan);
            Controls.Add(dgvKaryawan);
            Name = "KelolaKaryawanUC";
            Size = new Size(744, 451);
            Load += KelolaKaryawanUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private DataGridView dgvKaryawan;
        private Label lblKelolaKaryawan;
        private PictureBox pictbxAdd;
        private Button btnTambah;
        private PictureBox pictbxAddHov;
    }
}