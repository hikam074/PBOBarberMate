namespace PBOBarberMate.View.FormKelolaCustomer
{
    partial class FormKelolaCustomer
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
            lbcustomer = new Label();
            dataGridViewCustomer = new DataGridView();
            btKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // lbcustomer
            // 
            lbcustomer.AutoSize = true;
            lbcustomer.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbcustomer.Location = new Point(480, 37);
            lbcustomer.Name = "lbcustomer";
            lbcustomer.Size = new Size(239, 58);
            lbcustomer.TabIndex = 0;
            lbcustomer.Text = "List Customer";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(45, 117);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new Size(1095, 448);
            dataGridViewCustomer.TabIndex = 1;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // btKembali
            // 
            btKembali.Location = new Point(45, 595);
            btKembali.Name = "btKembali";
            btKembali.Size = new Size(108, 37);
            btKembali.TabIndex = 2;
            btKembali.Text = "Kembali";
            btKembali.UseVisualStyleBackColor = true;
            btKembali.Click += btKembali_Click;
            // 
            // FormKelolaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 656);
            Controls.Add(btKembali);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(lbcustomer);
            Name = "FormKelolaCustomer";
            Text = "FormKelolaCustomer";
            Load += FormKelolaCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbcustomer;
        private DataGridView dataGridViewCustomer;
        private Button btKembali;
    }
}