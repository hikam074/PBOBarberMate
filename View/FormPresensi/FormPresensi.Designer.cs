namespace PBOBarberMate.View.FormPresensi
{
    partial class FormPresensi
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
            lblPresensi = new Label();
            dgvPresensi = new DataGridView();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).BeginInit();
            SuspendLayout();
            // 
            // lblPresensi
            // 
            lblPresensi.AutoSize = true;
            lblPresensi.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold);
            lblPresensi.ForeColor = Color.FromArgb(44, 62, 80);
            lblPresensi.Location = new Point(320, 30);
            lblPresensi.Name = "lblPresensi";
            lblPresensi.Size = new Size(315, 58);
            lblPresensi.TabIndex = 0;
            lblPresensi.Text = "Jadwal Shift Anda";
            lblPresensi.Click += lblPresensi_Click;
            // 
            // dgvPresensi
            // 
            dgvPresensi.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPresensi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPresensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPresensi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPresensi.GridColor = Color.FromArgb(80, 61, 44);
            dgvPresensi.Location = new Point(75, 125);
            dgvPresensi.Margin = new Padding(3, 2, 3, 2);
            dgvPresensi.Name = "dgvPresensi";
            dgvPresensi.RowHeadersWidth = 51;
            dgvPresensi.Size = new Size(800, 324);
            dgvPresensi.TabIndex = 1;
            dgvPresensi.CellContentClick += dgvPresensi_CellContentClick;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.White;
            btnKembali.Font = new Font("Bahnschrift Condensed", 11.25F);
            btnKembali.ForeColor = Color.FromArgb(44, 62, 80);
            btnKembali.Location = new Point(15, 15);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 39);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormPresensi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(944, 501);
            Controls.Add(btnKembali);
            Controls.Add(dgvPresensi);
            Controls.Add(lblPresensi);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPresensi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPresensi";
            Load += FormPresensi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPresensi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPresensi;
        private DataGridView dgvPresensi;
        private Button btnKembali;
    }
}