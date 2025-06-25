namespace PBOBarberMate.View.Layanan
{
    partial class LayananTambahUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayananTambahUC));
            lblTambahLayanan = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            tbxHargaLayanan = new TextBox();
            tbxNamaLayanan = new TextBox();
            lblHarga = new Label();
            lblNamaLayanan = new Label();
            gbxLayananAdd = new GroupBox();
            pictbxAdd = new PictureBox();
            pictbxBack = new PictureBox();
            pictbxAddHov = new PictureBox();
            gbxLayananAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            SuspendLayout();
            // 
            // lblTambahLayanan
            // 
            lblTambahLayanan.AutoSize = true;
            lblTambahLayanan.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblTambahLayanan.Location = new Point(100, 40);
            lblTambahLayanan.Margin = new Padding(2, 0, 2, 0);
            lblTambahLayanan.Name = "lblTambahLayanan";
            lblTambahLayanan.Size = new Size(288, 39);
            lblTambahLayanan.TabIndex = 0;
            lblTambahLayanan.Text = "Tambahkan Layanan Baru";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(9, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Batalkan";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(447, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 39);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "      Tambahkan";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxHargaLayanan
            // 
            tbxHargaLayanan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxHargaLayanan.Location = new Point(90, 54);
            tbxHargaLayanan.Name = "tbxHargaLayanan";
            tbxHargaLayanan.Size = new Size(448, 23);
            tbxHargaLayanan.TabIndex = 18;
            tbxHargaLayanan.TextChanged += tbxHargaLayanan_TextChanged;
            // 
            // tbxNamaLayanan
            // 
            tbxNamaLayanan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxNamaLayanan.Location = new Point(90, 19);
            tbxNamaLayanan.Name = "tbxNamaLayanan";
            tbxNamaLayanan.Size = new Size(448, 23);
            tbxNamaLayanan.TabIndex = 17;
            tbxNamaLayanan.TextChanged += tbxNamaLayanan_TextChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblHarga.Location = new Point(6, 54);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(62, 18);
            lblHarga.TabIndex = 13;
            lblHarga.Text = "Harga : Rp.";
            // 
            // lblNamaLayanan
            // 
            lblNamaLayanan.AutoSize = true;
            lblNamaLayanan.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNamaLayanan.Location = new Point(6, 19);
            lblNamaLayanan.Name = "lblNamaLayanan";
            lblNamaLayanan.Size = new Size(78, 18);
            lblNamaLayanan.TabIndex = 12;
            lblNamaLayanan.Text = "Nama layanan";
            // 
            // gbxLayananAdd
            // 
            gbxLayananAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxLayananAdd.Controls.Add(pictbxAdd);
            gbxLayananAdd.Controls.Add(pictbxBack);
            gbxLayananAdd.Controls.Add(lblNamaLayanan);
            gbxLayananAdd.Controls.Add(btnAdd);
            gbxLayananAdd.Controls.Add(btnCancel);
            gbxLayananAdd.Controls.Add(tbxNamaLayanan);
            gbxLayananAdd.Controls.Add(lblHarga);
            gbxLayananAdd.Controls.Add(tbxHargaLayanan);
            gbxLayananAdd.Controls.Add(pictbxAddHov);
            gbxLayananAdd.Location = new Point(100, 100);
            gbxLayananAdd.Name = "gbxLayananAdd";
            gbxLayananAdd.Size = new Size(544, 150);
            gbxLayananAdd.TabIndex = 24;
            gbxLayananAdd.TabStop = false;
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(455, 117);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 25;
            pictbxAdd.TabStop = false;
            // 
            // pictbxBack
            // 
            pictbxBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictbxBack.BackColor = SystemColors.Control;
            pictbxBack.Image = (Image)resources.GetObject("pictbxBack.Image");
            pictbxBack.Location = new Point(16, 119);
            pictbxBack.Name = "pictbxBack";
            pictbxBack.Size = new Size(12, 12);
            pictbxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxBack.TabIndex = 24;
            pictbxBack.TabStop = false;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(455, 117);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 26;
            pictbxAddHov.TabStop = false;
            // 
            // LayananTambahUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbxLayananAdd);
            Controls.Add(lblTambahLayanan);
            Margin = new Padding(2);
            Name = "LayananTambahUC";
            Size = new Size(744, 451);
            Load += FormTambahLayanan_Load;
            gbxLayananAdd.ResumeLayout(false);
            gbxLayananAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTambahLayanan;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbxHargaLayanan;
        private TextBox tbxNamaLayanan;
        private Label lblHarga;
        private Label lblNamaLayanan;
        private GroupBox gbxLayananAdd;
        private PictureBox pictbxBack;
        private PictureBox pictbxAdd;
        private PictureBox pictbxAddHov;
    }
}