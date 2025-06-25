namespace PBOBarberMate.View.Inventaris
{
    partial class InventarisUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarisUC));
            btnTambah = new Button();
            lblInventaris = new Label();
            dgvInventaris = new DataGridView();
            pictbxAdd = new PictureBox();
            pictbxAddHov = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventaris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            SuspendLayout();
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
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.TextAlign = ContentAlignment.MiddleRight;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Visible = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblInventaris
            // 
            lblInventaris.AutoSize = true;
            lblInventaris.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblInventaris.Location = new Point(100, 40);
            lblInventaris.Margin = new Padding(2, 0, 2, 0);
            lblInventaris.Name = "lblInventaris";
            lblInventaris.Size = new Size(230, 39);
            lblInventaris.TabIndex = 5;
            lblInventaris.Text = "Stok Barang Saat Ini";
            // 
            // dgvInventaris
            // 
            dgvInventaris.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventaris.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventaris.BackgroundColor = SystemColors.Control;
            dgvInventaris.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventaris.Location = new Point(100, 100);
            dgvInventaris.Margin = new Padding(2);
            dgvInventaris.Name = "dgvInventaris";
            dgvInventaris.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvInventaris.Size = new Size(544, 300);
            dgvInventaris.TabIndex = 4;
            dgvInventaris.CellContentClick += dgvInventaris_CellContentClick;
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
            pictbxAdd.TabIndex = 27;
            pictbxAdd.TabStop = false;
            pictbxAdd.Visible = false;
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
            pictbxAddHov.TabIndex = 28;
            pictbxAddHov.TabStop = false;
            pictbxAddHov.Visible = false;
            // 
            // InventarisUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictbxAdd);
            Controls.Add(btnTambah);
            Controls.Add(lblInventaris);
            Controls.Add(dgvInventaris);
            Controls.Add(pictbxAddHov);
            Margin = new Padding(2);
            Name = "InventarisUC";
            Size = new Size(744, 451);
            ((System.ComponentModel.ISupportInitialize)dgvInventaris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTambah;
        private Label lblInventaris;
        private DataGridView dgvInventaris;
        private PictureBox pictbxAdd;
        private PictureBox pictbxAddHov;
    }
}