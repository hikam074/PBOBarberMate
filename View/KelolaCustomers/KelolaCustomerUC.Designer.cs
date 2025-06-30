namespace PBOBarberMate.View.KelolaCustomer
{
    partial class KelolaCustomerUC
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
            lblCustomer = new Label();
            dgvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold);
            lblCustomer.Location = new Point(100, 40);
            lblCustomer.Margin = new Padding(2, 0, 2, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(177, 39);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer Anda";
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.BackgroundColor = SystemColors.Control;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.GridColor = Color.Black;
            dgvCustomer.Location = new Point(100, 100);
            dgvCustomer.Margin = new Padding(2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.Size = new Size(544, 300);
            dgvCustomer.TabIndex = 1;
            dgvCustomer.ColumnHeaderMouseClick += dgvCustomer_ColumnHeaderMouseClick;
            // 
            // KelolaCustomerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvCustomer);
            Controls.Add(lblCustomer);
            Margin = new Padding(2);
            Name = "KelolaCustomerUC";
            Size = new Size(744, 451);
            Load += KelolaCustomerUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private DataGridView dgvCustomer;
    }
}