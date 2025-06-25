namespace PBOBarberMate.View.KelolaKaryawan
{
    partial class KelolaKaryawanTambahUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaKaryawanTambahUC));
            gbxLayananAdd = new GroupBox();
            pictbxAdd = new PictureBox();
            pictbxAddHov = new PictureBox();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            pictbxBack = new PictureBox();
            lblNama = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            tbxNama = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            lblTambah = new Label();
            gbxLayananAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).BeginInit();
            SuspendLayout();
            // 
            // gbxLayananAdd
            // 
            gbxLayananAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbxLayananAdd.BackColor = Color.Transparent;
            gbxLayananAdd.Controls.Add(pictbxAdd);
            gbxLayananAdd.Controls.Add(pictbxAddHov);
            gbxLayananAdd.Controls.Add(lblPassword);
            gbxLayananAdd.Controls.Add(tbxPassword);
            gbxLayananAdd.Controls.Add(pictbxBack);
            gbxLayananAdd.Controls.Add(lblNama);
            gbxLayananAdd.Controls.Add(btnAdd);
            gbxLayananAdd.Controls.Add(btnCancel);
            gbxLayananAdd.Controls.Add(tbxNama);
            gbxLayananAdd.Controls.Add(lblEmail);
            gbxLayananAdd.Controls.Add(tbxEmail);
            gbxLayananAdd.Location = new Point(100, 100);
            gbxLayananAdd.Name = "gbxLayananAdd";
            gbxLayananAdd.Size = new Size(544, 185);
            gbxLayananAdd.TabIndex = 26;
            gbxLayananAdd.TabStop = false;
            // 
            // pictbxAdd
            // 
            pictbxAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAdd.BackColor = Color.WhiteSmoke;
            pictbxAdd.Image = (Image)resources.GetObject("pictbxAdd.Image");
            pictbxAdd.Location = new Point(455, 152);
            pictbxAdd.Name = "pictbxAdd";
            pictbxAdd.Size = new Size(15, 15);
            pictbxAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAdd.TabIndex = 25;
            pictbxAdd.TabStop = false;
            // 
            // pictbxAddHov
            // 
            pictbxAddHov.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictbxAddHov.BackColor = Color.WhiteSmoke;
            pictbxAddHov.Image = (Image)resources.GetObject("pictbxAddHov.Image");
            pictbxAddHov.Location = new Point(455, 152);
            pictbxAddHov.Name = "pictbxAddHov";
            pictbxAddHov.Size = new Size(15, 15);
            pictbxAddHov.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxAddHov.TabIndex = 26;
            pictbxAddHov.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblPassword.Location = new Point(6, 89);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 18);
            lblPassword.TabIndex = 28;
            lblPassword.Text = "Password";
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxPassword.Location = new Point(90, 89);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(448, 23);
            tbxPassword.TabIndex = 27;
            tbxPassword.TextChanged += tbxPassword_TextChanged;
            // 
            // pictbxBack
            // 
            pictbxBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictbxBack.BackColor = SystemColors.Control;
            pictbxBack.Image = (Image)resources.GetObject("pictbxBack.Image");
            pictbxBack.Location = new Point(16, 154);
            pictbxBack.Name = "pictbxBack";
            pictbxBack.Size = new Size(12, 12);
            pictbxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictbxBack.TabIndex = 24;
            pictbxBack.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblNama.Location = new Point(6, 19);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(81, 18);
            lblNama.TabIndex = 12;
            lblNama.Text = "Nama Lengkap";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(447, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 39);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "      Tambahkan";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(6, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Batalkan";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift Condensed", 11.25F);
            lblEmail.Location = new Point(6, 54);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(35, 18);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxEmail.Location = new Point(90, 54);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(448, 23);
            tbxEmail.TabIndex = 18;
            tbxEmail.TextChanged += tbxEmail_TextChanged;
            // 
            // lblTambah
            // 
            lblTambah.AutoSize = true;
            lblTambah.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblTambah.Location = new Point(100, 40);
            lblTambah.Margin = new Padding(2, 0, 2, 0);
            lblTambah.Name = "lblTambah";
            lblTambah.Size = new Size(305, 39);
            lblTambah.TabIndex = 25;
            lblTambah.Text = "Tambahkan Karyawan Baru";
            // 
            // KelolaKaryawanTambahUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbxLayananAdd);
            Controls.Add(lblTambah);
            Name = "KelolaKaryawanTambahUC";
            Size = new Size(744, 451);
            gbxLayananAdd.ResumeLayout(false);
            gbxLayananAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictbxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxAddHov).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictbxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxLayananAdd;
        private PictureBox pictbxAdd;
        private PictureBox pictbxBack;
        private Label lblNama;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox tbxNama;
        private Label lblEmail;
        private TextBox tbxEmail;
        private PictureBox pictbxAddHov;
        private Label lblTambah;
        private TextBox tbxPassword;
        private Label lblPassword;
    }
}
