using Npgsql;
using PBOBarberMate.App.Context;
using PBOBarberMate.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBOBarberMate.View.FormKelolaKaryawan
{
    public partial class FiturPresensiKaryawan : Form
    {
        public int idPresensi { get; set; }
        public int idAkun { get; set; }
        public int idShift { get; set; }
        public DateTime waktuPresensi { get; set; }

        public FiturPresensiKaryawan()
        {
            InitializeComponent();
            LoadNamaAkunKaryawanData();
        }

        private void btnSelesaiFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Data Harus Lengkap Mohon Periksa Kembali");
                return;
            }
            
            else
            {
                //M_Presensi presensi = new M_Presensi
                //{
                //    //id_akun = (int)cbNamaAKUNFiturPresensiKaryawan.SelectedIndex,
                //    //id_shift = (int)cbHariShiftFiturPresensiKaryawan.SelectedValue,
                //    //waktu_presensi = (DateTime)dtpFiturPresensiKaryawan.Value
                //    nama_akun = (string)cbNamaAKUNFiturPresensiKaryawan.SelectedValue.ToString(),
                //    hari = (string)cbHariShiftFiturPresensiKaryawan.SelectedValue.ToString(),
                //    waktu_presensi = (DateTime)dtpFiturPresensiKaryawan.Value
                //};
                idShift = (int)cbHariShiftFiturPresensiKaryawan.SelectedValue;
                waktuPresensi = (DateTime)dtpFiturPresensiKaryawan.Value;
                PresensiContext.UpdatePresensi(idPresensi,idAkun,idShift,waktuPresensi);
                MessageBox.Show("Data Presensi Berhasil diubah");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
            FormKelolaKaryawan formKelolaKaryawan = new FormKelolaKaryawan();
            formKelolaKaryawan.ShowDialog();
        }



        private bool ValidateInput()
        {
            if (cbNamaAKUNFiturPresensiKaryawan.SelectedValue == null ||
                cbNamaAKUNFiturPresensiKaryawan.SelectedValue == null
                )
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            cbNamaAKUNFiturPresensiKaryawan.SelectedIndex = -1;
            cbHariShiftFiturPresensiKaryawan.SelectedIndex = -1;
            dtpFiturPresensiKaryawan.Value = dtpFiturPresensiKaryawan.MinDate; // Mengatur ke tanggal minimum

        }

        private void btnBatalFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        public void PopulateForm(M_Presensi karyawan)
        {
            cbNamaAKUNFiturPresensiKaryawan.SelectedValue= karyawan.id_akun;
            cbHariShiftFiturPresensiKaryawan.SelectedValue= karyawan.id_shift;
            dtpFiturPresensiKaryawan.Value = karyawan.waktu_presensi;
            idPresensi = karyawan.id_presensi;
            idAkun = karyawan.id_akun;
        }
        private void LoadNamaAkunKaryawanData()
        {
            //MessageBox.Show(presensi.id_presensi.ToString());
            DataTable dataAkunKaryawan = PresensiContext.GetJadwalShiftKaryawanbyIdPresensi(idPresensi);
            cbNamaAKUNFiturPresensiKaryawan.DisplayMember = "nama_akun";
            cbNamaAKUNFiturPresensiKaryawan.ValueMember = "id_akun";
            cbNamaAKUNFiturPresensiKaryawan.DataSource = dataAkunKaryawan;
            cbNamaAKUNFiturPresensiKaryawan.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadShiftKaryawanData()
        {
            DataTable dataShiftKaryawan = PresensiContext.GetJadwalShiftKaryawanbyIdAkun(idAkun);
            cbHariShiftFiturPresensiKaryawan.DisplayMember = "nama_hari";
            cbHariShiftFiturPresensiKaryawan.ValueMember = "id_shift";
            cbHariShiftFiturPresensiKaryawan.DataSource = dataShiftKaryawan;
            cbHariShiftFiturPresensiKaryawan.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cbIDAKUNFiturPresensiKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShiftKaryawanData();
        }
    }
}
