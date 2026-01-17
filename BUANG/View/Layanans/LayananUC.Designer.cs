//namespace PBOBarberMate.View.Layanan
//{
//    partial class LayananUC
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayananUC));
//            dgvLayanan = new DataGridView();
//            lblLayanan = new Label();
//            btnTambah = new Button();
//            pictbxAdd = new PictureBox();
//            pictbxAddHov = new PictureBox();
//            ((System.ComponentModel.ISupportInitialize)dgvLayanan).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
//            SuspendLayout();
//            // 
//            // dgvLayanan
//            // 
//            dgvLayanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
//            dgvLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dgvLayanan.BackgroundColor = SystemColors.Control;
//            dgvLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dgvLayanan.Location = new Point(100, 100);
//            dgvLayanan.Margin = new Padding(2);
//            dgvLayanan.Name = "dgvLayanan";
//            dgvLayanan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
//            dgvLayanan.Size = new Size(544, 300);
//            dgvLayanan.TabIndex = 0;
//            dgvLayanan.CellContentClick += dgvLayanan_CellContentClick;
//            dgvLayanan.ColumnHeaderMouseClick += dgvLayanan_ColumnHeaderMouseClick;
//            // 
//            // lblLayanan
//            // 
//            lblLayanan.AutoSize = true;
//            lblLayanan.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblLayanan.Location = new Point(100, 40);
//            lblLayanan.Margin = new Padding(2, 0, 2, 0);
//            lblLayanan.Name = "lblLayanan";
//            lblLayanan.Size = new Size(201, 39);
//            lblLayanan.TabIndex = 1;
//            lblLayanan.Text = "Layanan Tersedia";
//            // 
//            // btnTambah
//            // 
//            btnTambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnTambah.BackColor = SystemColors.Control;
//            btnTambah.Font = new Font("Bahnschrift Condensed", 11.25F);
//            btnTambah.ForeColor = Color.Black;
//            btnTambah.Location = new Point(569, 40);
//            btnTambah.Margin = new Padding(2);
//            btnTambah.Name = "btnTambah";
//            btnTambah.Size = new Size(75, 39);
//            btnTambah.TabIndex = 2;
//            btnTambah.Text = "Tambah";
//            btnTambah.TextAlign = ContentAlignment.MiddleRight;
//            btnTambah.UseVisualStyleBackColor = false;
//            btnTambah.Visible = false;
//            btnTambah.Click += btnTambah_Click;
//            // 
//            // pictbxAdd
//            // 
//            pictbxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            pictbxAdd.BackColor = Color.WhiteSmoke;
//            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
//            pictbxAdd.Location = new Point(578, 52);
//            pictbxAdd.Name = "pictbxAdd";
//            pictbxAdd.Size = new Size(15, 15);
//            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
//            pictbxAdd.TabIndex = 26;
//            pictbxAdd.TabStop = false;
//            pictbxAdd.Visible = false;
//            // 
//            // pictbxAddHov
//            // 
//            pictbxAddHov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            pictbxAddHov.BackColor = Color.WhiteSmoke;
//            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
//            pictbxAddHov.Location = new Point(578, 52);
//            pictbxAddHov.Name = "pictbxAddHov";
//            pictbxAddHov.Size = new Size(15, 15);
//            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
//            pictbxAddHov.TabIndex = 27;
//            pictbxAddHov.TabStop = false;
//            pictbxAddHov.Visible = false;
//            // 
//            // LayananUC
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.White;
//            Controls.Add(pictbxAdd);
//            Controls.Add(btnTambah);
//            Controls.Add(lblLayanan);
//            Controls.Add(dgvLayanan);
//            Controls.Add(pictbxAddHov);
//            Margin = new Padding(2);
//            Name = "LayananUC";
//            Size = new Size(744, 451);
//            Load += FormLayanan_Load;
//            ((System.ComponentModel.ISupportInitialize)dgvLayanan).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
//            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private DataGridView dgvLayanan;
//        private Label lblLayanan;
//        private Button btnTambah;
//        private PictureBox pictbxAdd;
//        private PictureBox pictbxAddHov;
//    }
//}