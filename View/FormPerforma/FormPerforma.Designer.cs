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
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btkembali
            // 
            btkembali.Location = new Point(28, 464);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(291, 204);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 141);
            label3.Name = "label3";
            label3.Size = new Size(256, 25);
            label3.TabIndex = 3;
            label3.Text = "Anda mendapat rating sebesar";
            label3.Click += label3_Click;
            // 
            // FormPerforma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 523);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btkembali);
            Name = "FormPerforma";
            Text = "BarberMate";
            Load += FormPerforma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btkembali;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}