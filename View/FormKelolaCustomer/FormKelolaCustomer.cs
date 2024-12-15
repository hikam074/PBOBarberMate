using PBOBarberMate.App.Context;
using PBOBarberMate.App.Core;
using PBOBarberMate.App.Model;
using PBOBarberMate.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View.FormKelolaCustomer
{
    public partial class FormKelolaCustomer : Form
    {
        public FormKelolaCustomer()
        {
            InitializeComponent();
            this.Load += FormKelolaCustomer_Load;
        }


        private void FormKelolaCustomer_Load(object sender, EventArgs e)
        {
            LoadDataCustomer();

        }

        private void LoadDataCustomer()
        {
            try
            {
                dataGridViewCustomer.AllowUserToAddRows = false;
                DataTable CustomerData = CustomerContext.All();
                if (CustomerData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data customer");
                    return;
                }
                dataGridViewCustomer.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridViewCustomer.Columns.Add(nomorColumn);

                dataGridViewCustomer.DataSource = CustomerData;

                if (dataGridViewCustomer.Columns["id_akun"] != null)
                    dataGridViewCustomer.Columns["id_akun"].Visible = false;
                if (dataGridViewCustomer.Columns["nama_akun"] != null)
                    dataGridViewCustomer.Columns["nama_akun"].HeaderText = "Username";
                if (dataGridViewCustomer.Columns["email"] != null)
                    dataGridViewCustomer.Columns["email"].HeaderText = "Email";
                if (dataGridViewCustomer.Columns["password"] != null)
                    dataGridViewCustomer.Columns["password"].Visible = false;
                if (dataGridViewCustomer.Columns["akun_role_id"] != null)
                    dataGridViewCustomer.Columns["akun_role_id"].Visible = false;


                for (int i = 0; i < dataGridViewCustomer.Rows.Count; i++)
                {
                    dataGridViewCustomer.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load Data Customer: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            FormHomepageAdmin admin = new FormHomepageAdmin();
            this.Hide();
            admin.Show();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }
    }




}
