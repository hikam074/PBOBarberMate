namespace PBOBarberMate.Presentation.Views.Jadwal
{
    partial class FormPilihanStatus
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
            btnLibur = new Button();
            btnSibuk = new Button();
            btnTersedia = new Button();
            groupBox1 = new GroupBox();
            lblInfo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLibur
            // 
            btnLibur.Cursor = Cursors.Hand;
            btnLibur.Location = new Point(169, 22);
            btnLibur.Name = "btnLibur";
            btnLibur.Size = new Size(75, 23);
            btnLibur.TabIndex = 0;
            btnLibur.Text = "Libur";
            btnLibur.UseVisualStyleBackColor = true;
            btnLibur.Click += btnLibur_Click;
            // 
            // btnSibuk
            // 
            btnSibuk.Cursor = Cursors.Hand;
            btnSibuk.Location = new Point(88, 22);
            btnSibuk.Name = "btnSibuk";
            btnSibuk.Size = new Size(75, 23);
            btnSibuk.TabIndex = 1;
            btnSibuk.Text = "Sibuk";
            btnSibuk.UseVisualStyleBackColor = true;
            btnSibuk.Click += btnSibuk_Click;
            // 
            // btnTersedia
            // 
            btnTersedia.Cursor = Cursors.Hand;
            btnTersedia.Location = new Point(6, 22);
            btnTersedia.Name = "btnTersedia";
            btnTersedia.Size = new Size(75, 23);
            btnTersedia.TabIndex = 2;
            btnTersedia.Text = "Tersedia";
            btnTersedia.UseVisualStyleBackColor = true;
            btnTersedia.Click += btnTersedia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTersedia);
            groupBox1.Controls.Add(btnSibuk);
            groupBox1.Controls.Add(btnLibur);
            groupBox1.Location = new Point(16, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 54);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atur Aksi";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(16, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(228, 15);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Jadwal \"NamaKaryawan\" hari \"NamaHari\"";
            // 
            // FormPilihanStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(lblInfo);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPilihanStatus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detail Jadwal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLibur;
        private Button btnSibuk;
        private Button btnTersedia;
        private GroupBox groupBox1;
        private Label lblInfo;
    }
}