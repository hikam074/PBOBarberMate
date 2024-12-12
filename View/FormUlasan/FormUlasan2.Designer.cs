namespace PBOBarberMate.View.FormUlasan
{
    partial class FormUlasan2
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
            btnTambah = new Button();
            lblLayanan = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(23, 644);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(111, 33);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1084, 644);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 33);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "TAMBAH";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // lblLayanan
            // 
            lblLayanan.AutoSize = true;
            lblLayanan.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLayanan.Location = new Point(503, 37);
            lblLayanan.Name = "lblLayanan";
            lblLayanan.Size = new Size(277, 58);
            lblLayanan.TabIndex = 5;
            lblLayanan.Text = "List Pembayaran";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1173, 502);
            dataGridView1.TabIndex = 4;
            // 
            // FormUlasan2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 713);
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(lblLayanan);
            Controls.Add(dataGridView1);
            Name = "FormUlasan2";
            Text = "FormUlasan2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Button btnTambah;
        private Label lblLayanan;
        private DataGridView dataGridView1;
    }
}