namespace PBOBarberMate.View.Shift
{
    partial class ShiftUC
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
            lblShift = new Label();
            dgvShift = new DataGridView();
            lblKiat = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShift).BeginInit();
            SuspendLayout();
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblShift.ForeColor = Color.Black;
            lblShift.Location = new Point(100, 40);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(259, 39);
            lblShift.TabIndex = 0;
            lblShift.Text = "Jadwal Shift Karyawan";
            // 
            // dgvShift
            // 
            dgvShift.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShift.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvShift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvShift.DefaultCellStyle = dataGridViewCellStyle2;
            dgvShift.GridColor = Color.Black;
            dgvShift.Location = new Point(100, 100);
            dgvShift.Margin = new Padding(3, 2, 3, 2);
            dgvShift.Name = "dgvShift";
            dgvShift.RowHeadersWidth = 51;
            dgvShift.Size = new Size(544, 300);
            dgvShift.TabIndex = 1;
            dgvShift.CellClick += dgvShift_CellClick;
            dgvShift.CellFormatting += dgvShift_CellFormatting;
            // 
            // lblKiat
            // 
            lblKiat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKiat.AutoSize = true;
            lblKiat.ForeColor = Color.Gray;
            lblKiat.Location = new Point(413, 49);
            lblKiat.Margin = new Padding(0, 3, 0, 3);
            lblKiat.Name = "lblKiat";
            lblKiat.Size = new Size(231, 30);
            lblKiat.TabIndex = 2;
            lblKiat.Text = "Klik sel shift kosong untuk menambahkan,\r\nKlik sel shift terisi untuk menghapus";
            lblKiat.TextAlign = ContentAlignment.BottomRight;
            // 
            // ShiftUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblKiat);
            Controls.Add(dgvShift);
            Controls.Add(lblShift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShiftUC";
            Size = new Size(744, 451);
            Load += FormShift_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShift;
        private DataGridView dgvShift;
        private Label lblKiat;
    }
}