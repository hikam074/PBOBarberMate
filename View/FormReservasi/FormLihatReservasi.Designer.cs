namespace PBOBarberMate.View.FormReservasi
{
    partial class FormLihatReservasi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvDataReservasi = new DataGridView();
            lblTitle = new Label();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).BeginInit();
            SuspendLayout();
            // 
            // dgvDataReservasi
            // 
            dgvDataReservasi.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataReservasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDataReservasi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDataReservasi.Location = new Point(95, 120);
            dgvDataReservasi.Name = "dgvDataReservasi";
            dgvDataReservasi.Size = new Size(749, 310);
            dgvDataReservasi.TabIndex = 1;
            dgvDataReservasi.CellContentClick += dgvDataReservasi_CellContentClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(230, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(485, 58);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Reservasi && Kunjungan Anda";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(15, 15);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 9;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormLihatReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(944, 501);
            Controls.Add(btnKembali);
            Controls.Add(lblTitle);
            Controls.Add(dgvDataReservasi);
            Name = "FormLihatReservasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLihatReservasi";
            Load += FormLihatReservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDataReservasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDataReservasi;
        public Label lblTitle;
        private Button btnKembali;
    }
}