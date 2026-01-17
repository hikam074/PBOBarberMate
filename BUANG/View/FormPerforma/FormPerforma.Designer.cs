namespace PBOBarberMate.View.FormPerforma
{
    partial class FormPerforma
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
            btkembali = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btkembali
            // 
            btkembali.Location = new Point(62, 477);
            btkembali.Name = "btkembali";
            btkembali.Size = new Size(112, 34);
            btkembali.TabIndex = 0;
            btkembali.Text = "Kembali";
            btkembali.UseVisualStyleBackColor = true;
            btkembali.Click += btkembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(240, 53);
            label1.TabIndex = 1;
            label1.Text = "Performa Anda";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(62, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(822, 274);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormPerforma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 523);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btkembali);
            Name = "FormPerforma";
            Text = "BarberMate";
            Load += FormPerforma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btkembali;
        private Label label1;
        private DataGridView dataGridView1;
    }
}