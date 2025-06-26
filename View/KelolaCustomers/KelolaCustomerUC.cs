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

using PBOBarberMate.App.Model;
using PBOBarberMate.App.Services;
using PBOBarberMate.App.Utils;


namespace PBOBarberMate.View.KelolaCustomer
{
    public partial class KelolaCustomerUC : UserControl
    {
        private readonly CommonAppServices _commonServices;


        public KelolaCustomerUC(CommonAppServices commonServices)
        {
            InitializeComponent();
            _commonServices = commonServices;

            this.Load += KelolaCustomerUC_Load;
        }

        private void KelolaCustomerUC_Load(object sender, EventArgs e)
        {
            LoadDgvCustomer();
        }
        private void LoadDgvCustomer()
        {
            List<M_Customer> daftar = _commonServices.AkunServiceInstance.getAllCustomer();
            // set juga var global internal
            customerList = daftar;

            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.Columns.Clear();

            // kolom dengan header kustom
            dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Customer",
                DataPropertyName = "id_akun",
                Name = "colId"
            });
            dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nama Lengkap",
                DataPropertyName = "nama",
                Name = "colNama"
            });
            dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Alamat Email",
                DataPropertyName = "email",
                Name = "colEmail"
            });

            dgvCustomer.DataSource = daftar;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private List<M_Customer> customerList;
        private void dgvCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSorter.Sort(dgvCustomer, e, ref customerList);
        }
    }
}
