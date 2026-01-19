namespace PBOBarberMate.Presentation.Views.Shared
{
    partial class NavbarUC
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
            if (disposing)
            {
                // Tambahkan baris ini di sini
                System.Windows.Forms.Application.RemoveMessageFilter(this);

                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavbarUC));
            lblHeaderMenu = new Label();
            pictboxHome = new PictureBox();
            lblHomepageGreet = new Label();
            btnProfil = new Button();
            pictboxProfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictboxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictboxProfil).BeginInit();
            SuspendLayout();
            // 
            // lblHeaderMenu
            // 
            lblHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderMenu.AutoSize = true;
            lblHeaderMenu.BackColor = Color.Transparent;
            lblHeaderMenu.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderMenu.ForeColor = Color.White;
            lblHeaderMenu.Location = new Point(442, 13);
            lblHeaderMenu.Name = "lblHeaderMenu";
            lblHeaderMenu.Size = new Size(13, 23);
            lblHeaderMenu.TabIndex = 1;
            lblHeaderMenu.Text = ".";
            lblHeaderMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictboxHome
            // 
            pictboxHome.Cursor = Cursors.Hand;
            pictboxHome.Image = (Image)resources.GetObject("pictboxHome.Image");
            pictboxHome.Location = new Point(3, 3);
            pictboxHome.Name = "pictboxHome";
            pictboxHome.Size = new Size(45, 45);
            pictboxHome.SizeMode = PictureBoxSizeMode.CenterImage;
            pictboxHome.TabIndex = 9;
            pictboxHome.TabStop = false;
            // 
            // lblHomepageGreet
            // 
            lblHomepageGreet.AutoSize = true;
            lblHomepageGreet.BackColor = Color.Transparent;
            lblHomepageGreet.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHomepageGreet.ForeColor = Color.White;
            lblHomepageGreet.Location = new Point(53, 13);
            lblHomepageGreet.Name = "lblHomepageGreet";
            lblHomepageGreet.Size = new Size(84, 23);
            lblHomepageGreet.TabIndex = 8;
            lblHomepageGreet.Text = "BarberMate";
            lblHomepageGreet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.AutoSize = true;
            btnProfil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProfil.BackColor = Color.White;
            btnProfil.Cursor = Cursors.Hand;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Bahnschrift Condensed", 12F);
            btnProfil.ForeColor = Color.Black;
            btnProfil.Location = new Point(884, 11);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(48, 29);
            btnProfil.TabIndex = 10;
            btnProfil.Text = "Profil";
            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // pictboxProfil
            // 
            pictboxProfil.BackColor = Color.White;
            pictboxProfil.Image = (Image)resources.GetObject("pictboxProfil.Image");
            pictboxProfil.Location = new Point(852, 11);
            pictboxProfil.Name = "pictboxProfil";
            pictboxProfil.Size = new Size(29, 29);
            pictboxProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictboxProfil.TabIndex = 11;
            pictboxProfil.TabStop = false;
            // 
            // NavbarUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            Controls.Add(btnProfil);
            Controls.Add(pictboxProfil);
            Controls.Add(pictboxHome);
            Controls.Add(lblHomepageGreet);
            Controls.Add(lblHeaderMenu);
            Name = "NavbarUC";
            Size = new Size(944, 50);
            ((System.ComponentModel.ISupportInitialize)pictboxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictboxProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblHeaderMenu;
        private PictureBox pictboxHome;
        private Label lblHomepageGreet;
        private Button btnProfil;
        private PictureBox pictboxProfil;
    }
}
