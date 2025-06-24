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
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            tbxHargaLayanan = new TextBox();
            tbxNamaLayanan = new TextBox();
            lblHarga = new Label();
            lblNamaLayanan = new Label();
            gbxLayananAdd = new GroupBox();
            gbxLayananAdd.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            label1.Location = new Point(100, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 39);
            label1.TabIndex = 0;
            label1.Text = "Tambahkan Layanan Baru";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(9, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(463, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 39);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
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
            gbxLayananAdd.Controls.Add(lblNamaLayanan);
            gbxLayananAdd.Controls.Add(btnAdd);
            gbxLayananAdd.Controls.Add(btnCancel);
            gbxLayananAdd.Controls.Add(tbxNamaLayanan);
            gbxLayananAdd.Controls.Add(lblHarga);
            gbxLayananAdd.Controls.Add(tbxHargaLayanan);
            gbxLayananAdd.Location = new Point(100, 100);
            gbxLayananAdd.Name = "gbxLayananAdd";
            gbxLayananAdd.Size = new Size(544, 150);
            gbxLayananAdd.TabIndex = 24;
            gbxLayananAdd.TabStop = false;
            // 
            // LayananTambahUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbxLayananAdd);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LayananTambahUC";
            Size = new Size(744, 451);
            Load += FormTambahLayanan_Load;
            gbxLayananAdd.ResumeLayout(false);
            gbxLayananAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbxHargaLayanan;
        private TextBox tbxNamaLayanan;
        private Label lblHarga;
        private Label lblNamaLayanan;
        private GroupBox gbxLayananAdd;
    }
}