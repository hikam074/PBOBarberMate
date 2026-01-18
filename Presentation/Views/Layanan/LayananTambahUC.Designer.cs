namespace PBOBarberMate.Presentation.Views.Layanan
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
            tbxNama = new TextBox();
            lblHarga = new Label();
            lblNamaLayanan = new Label();
            gbxLayananAdd = new GroupBox();
            numHarga = new NumericUpDown();
            lblDeskripsi = new Label();
            tbxDeskripsi = new TextBox();
            pictbxAdd = new PictureBox();
            pictbxBack = new PictureBox();
            pictbxAddHov = new PictureBox();
            gbxLayananAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHarga).BeginInit();
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
            btnCancel.Location = new Point(9, 130);
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
            btnAdd.Location = new Point(447, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 39);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "      Tambahkan";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxNama
            // 
            tbxNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxNama.Location = new Point(90, 19);
            tbxNama.Name = "tbxNama";
            tbxNama.Size = new Size(448, 23);
            tbxNama.TabIndex = 17;
            tbxNama.TextChanged += tbxNama_TextChanged;
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
            gbxLayananAdd.Controls.Add(numHarga);
            gbxLayananAdd.Controls.Add(lblDeskripsi);
            gbxLayananAdd.Controls.Add(tbxDeskripsi);
            gbxLayananAdd.Controls.Add(pictbxAdd);
            gbxLayananAdd.Controls.Add(pictbxBack);
            gbxLayananAdd.Controls.Add(lblNamaLayanan);
            gbxLayananAdd.Controls.Add(btnAdd);
            gbxLayananAdd.Controls.Add(btnCancel);
            gbxLayananAdd.Controls.Add(tbxNama);
            gbxLayananAdd.Controls.Add(lblHarga);
            gbxLayananAdd.Controls.Add(pictbxAddHov);
            gbxLayananAdd.Location = new Point(100, 100);
            gbxLayananAdd.Name = "gbxLayananAdd";
            gbxLayananAdd.Size = new Size(544, 175);
            gbxLayananAdd.TabIndex = 24;
            gbxLayananAdd.TabStop = false;
            // 
            // numHarga
            // 
            numHarga.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numHarga.Location = new Point(90, 54);
            numHarga.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numHarga.Name = "numHarga";
            numHarga.Size = new Size(448, 23);
            numHarga.TabIndex = 29;
            numHarga.ValueChanged += numHarga_ValueChanged;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblDeskripsi.Location = new Point(6, 86);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(53, 18);
            lblDeskripsi.TabIndex = 27;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // tbxDeskripsi
            // 
            tbxDeskripsi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxDeskripsi.Location = new Point(90, 86);
            tbxDeskripsi.Name = "tbxDeskripsi";
            tbxDeskripsi.Size = new Size(448, 23);
            tbxDeskripsi.TabIndex = 28;
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(455, 142);
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
            pictbxBack.Location = new Point(16, 144);
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
            pictbxAddHov.Location = new Point(455, 142);
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
            gbxLayananAdd.ResumeLayout(false);
            gbxLayananAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHarga).EndInit();
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
        private TextBox tbxNama;
        private Label lblHarga;
        private Label lblNamaLayanan;
        private GroupBox gbxLayananAdd;
        private PictureBox pictbxBack;
        private PictureBox pictbxAdd;
        private PictureBox pictbxAddHov;
        private Label lblDeskripsi;
        private TextBox tbxDeskripsi;
        private NumericUpDown numHarga;
    }
}