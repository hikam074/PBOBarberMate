namespace PBOBarberMate.Presentation.Views.Shared
{
    partial class HomepageUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            sidebarPanel = new Panel();
            contentAreaPanel = new Panel();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(44, 62, 80);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(944, 50);
            headerPanel.TabIndex = 7;
            headerPanel.Resize += headerPanel_Resize;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(145, 197, 249);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 50);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 451);
            sidebarPanel.TabIndex = 0;
            // 
            // contentAreaPanel
            // 
            contentAreaPanel.BackColor = Color.Transparent;
            contentAreaPanel.Dock = DockStyle.Fill;
            contentAreaPanel.Location = new Point(200, 50);
            contentAreaPanel.Name = "contentAreaPanel";
            contentAreaPanel.Size = new Size(744, 451);
            contentAreaPanel.TabIndex = 1;
            // 
            // HomepageUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(contentAreaPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(headerPanel);
            Name = "HomepageUC";
            Size = new Size(944, 501);
            ResumeLayout(false);
        }

        #endregion
        // Deklarasi komponen baru
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentAreaPanel;
    }
}
