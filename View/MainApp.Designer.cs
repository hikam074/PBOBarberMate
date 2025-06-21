namespace PBOBarberMate.View
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            mainContentPanel = new Panel();
            SuspendLayout();
            // 
            // mainContentPanel
            // 
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(0, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(1008, 540);
            mainContentPanel.TabIndex = 0;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 540);
            Controls.Add(mainContentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 576);
            Name = "MainApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarberMate";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainContentPanel;
    }
}