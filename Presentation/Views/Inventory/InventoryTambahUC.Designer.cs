namespace PBOBarberMate.Presentation.Views.Inventory
{
    partial class InventoryTambahUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTambahUC));
            btnCancel = new Button();
            btnAdd = new Button();
            tbxNama = new TextBox();
            lblJumlah = new Label();
            lblNama = new Label();
            lblTambahInventaris = new Label();
            gbxAdd = new GroupBox();
            numStok = new NumericUpDown();
            lblSatuan = new Label();
            tbxSatuan = new TextBox();
            pictbxAdd = new PictureBox();
            pictbxBack = new PictureBox();
            pictbxAddHov = new PictureBox();
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(9, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Batalkan";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(447, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 39);
            btnAdd.TabIndex = 29;
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
            tbxNama.TabIndex = 27;
            tbxNama.TextChanged += tbxNama_TextChanged;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblJumlah.Location = new Point(6, 48);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(30, 18);
            lblJumlah.TabIndex = 26;
            lblJumlah.Text = "Stok";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNama.Location = new Point(6, 19);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(74, 18);
            lblNama.TabIndex = 25;
            lblNama.Text = "Nama Barang";
            // 
            // lblTambahInventaris
            // 
            lblTambahInventaris.AutoSize = true;
            lblTambahInventaris.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblTambahInventaris.Location = new Point(100, 40);
            lblTambahInventaris.Margin = new Padding(2, 0, 2, 0);
            lblTambahInventaris.Name = "lblTambahInventaris";
            lblTambahInventaris.Size = new Size(274, 39);
            lblTambahInventaris.TabIndex = 24;
            lblTambahInventaris.Text = "Tambahkan Barang Baru";
            lblTambahInventaris.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxAdd
            // 
            gbxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxAdd.Controls.Add(numStok);
            gbxAdd.Controls.Add(lblSatuan);
            gbxAdd.Controls.Add(tbxSatuan);
            gbxAdd.Controls.Add(pictbxAdd);
            gbxAdd.Controls.Add(pictbxBack);
            gbxAdd.Controls.Add(lblNama);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(btnCancel);
            gbxAdd.Controls.Add(tbxNama);
            gbxAdd.Controls.Add(lblJumlah);
            gbxAdd.Controls.Add(pictbxAddHov);
            gbxAdd.Location = new Point(100, 100);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(544, 170);
            gbxAdd.TabIndex = 31;
            gbxAdd.TabStop = false;
            // 
            // numStok
            // 
            numStok.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numStok.Location = new Point(90, 48);
            numStok.Name = "numStok";
            numStok.Size = new Size(448, 23);
            numStok.TabIndex = 36;
            numStok.ValueChanged += numStok_ValueChanged;
            // 
            // lblSatuan
            // 
            lblSatuan.AutoSize = true;
            lblSatuan.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblSatuan.Location = new Point(6, 77);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(73, 18);
            lblSatuan.TabIndex = 34;
            lblSatuan.Text = "Nama Satuan";
            // 
            // tbxSatuan
            // 
            tbxSatuan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxSatuan.Location = new Point(90, 77);
            tbxSatuan.Name = "tbxSatuan";
            tbxSatuan.Size = new Size(448, 23);
            tbxSatuan.TabIndex = 35;
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(455, 137);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 32;
            pictbxAdd.TabStop = false;
            // 
            // pictbxBack
            // 
            pictbxBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictbxBack.BackColor = SystemColors.Control;
            pictbxBack.Image = (Image)resources.GetObject("pictbxBack.Image");
            pictbxBack.Location = new Point(16, 139);
            pictbxBack.Name = "pictbxBack";
            pictbxBack.Size = new Size(12, 12);
            pictbxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxBack.TabIndex = 31;
            pictbxBack.TabStop = false;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(455, 137);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 33;
            pictbxAddHov.TabStop = false;
            // 
            // InventoryTambahUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbxAdd);
            Controls.Add(lblTambahInventaris);
            Margin = new Padding(2);
            Name = "InventoryTambahUC";
            Size = new Size(744, 451);
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbxNama;
        private Label lblJumlah;
        private Label lblNama;
        private Label lblTambahInventaris;
        private GroupBox gbxAdd;
        private PictureBox pictbxBack;
        private PictureBox pictbxAdd;
        private PictureBox pictbxAddHov;
        private Label lblSatuan;
        private TextBox tbxSatuan;
        private NumericUpDown numStok;
    }
}