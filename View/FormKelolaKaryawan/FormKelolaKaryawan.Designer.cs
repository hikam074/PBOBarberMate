namespace PBOBarberMate.View.FormKelolaKaryawan
{
    partial class FormKelolaKaryawan
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
            btnKembali = new Button();
            dataGridViewKelolaKaryawan = new DataGridView();
            lblKelolaKaryawan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKaryawan).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(26, 405);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(78, 20);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKelolaKaryawan
            // 
            dataGridViewKelolaKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKelolaKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKelolaKaryawan.Location = new Point(26, 90);
            dataGridViewKelolaKaryawan.Margin = new Padding(2);
            dataGridViewKelolaKaryawan.Name = "dataGridViewKelolaKaryawan";
            dataGridViewKelolaKaryawan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewKelolaKaryawan.Size = new Size(821, 301);
            dataGridViewKelolaKaryawan.TabIndex = 5;
            dataGridViewKelolaKaryawan.CellContentClick += dataGridViewKelolaKaryawan_CellContentClick;
            // 
            // lblKelolaKaryawan
            // 
            lblKelolaKaryawan.AutoSize = true;
            lblKelolaKaryawan.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKelolaKaryawan.Location = new Point(297, 30);
            lblKelolaKaryawan.Margin = new Padding(2, 0, 2, 0);
            lblKelolaKaryawan.Name = "lblKelolaKaryawan";
            lblKelolaKaryawan.Size = new Size(258, 39);
            lblKelolaKaryawan.TabIndex = 7;
            lblKelolaKaryawan.Text = "Daftar Hadir Karyawan";
            // 
            // FormKelolaKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 450);
            Controls.Add(lblKelolaKaryawan);
            Controls.Add(dataGridViewKelolaKaryawan);
            Controls.Add(btnKembali);
            Name = "FormKelolaKaryawan";
            Text = "KelolaKaryawan";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKelolaKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private DataGridView dataGridViewKelolaKaryawan;
        private Label lblKelolaKaryawan;
    }
}