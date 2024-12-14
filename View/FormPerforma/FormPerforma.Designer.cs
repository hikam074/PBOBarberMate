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
            // FormPerforma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 523);
            Controls.Add(btkembali);
            Name = "FormPerforma";
            Text = "Form1";
            Load += FormPerforma_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btkembali;
    }
}