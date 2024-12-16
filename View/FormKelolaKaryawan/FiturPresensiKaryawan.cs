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
        public bool IsEditMode { get; set; } = false;
        public int idPresensi { get; set; }

        public FiturPresensiKaryawan()
        {
            InitializeComponent();
            UpdateButtonText();
        }

        private void btnSelesaiFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Data Harus Lengkap Mohon Periksa Kembali");
                return;
            }
            M_Presensi presensi = new M_Presensi
            {
                id_akun = int.Parse(tbIDAKUNFiturPresensiKaryawan.Text),
                id_shift = int.Parse(tbIDSHIFTFiturPresensiKaryawan.Text),
                waktu_presensi = dtpFiturPresensiKaryawan.Value,
            };
            
            if (IsEditMode)
            {
                PresensiContext.UpdatePresensi(presensi);
                MessageBox.Show("Jadwal berhasil diubah");
            }
            else
            {
                PresensiContext.AddPresensi(presensi);
                MessageBox.Show("Jadwal berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
            FormKelolaKaryawan formKelolaKaryawan = new FormKelolaKaryawan();
            formKelolaKaryawan.ShowDialog();
        }



        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbIDAKUNFiturPresensiKaryawan.Text) ||
                string.IsNullOrWhiteSpace(tbIDSHIFTFiturPresensiKaryawan.Text) 
                )
            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            tbIDAKUNFiturPresensiKaryawan.Clear();
            tbIDSHIFTFiturPresensiKaryawan.Clear();
            dtpFiturPresensiKaryawan.Value = dtpFiturPresensiKaryawan.MinDate; 
            // Mengatur ke tanggal minimum
        }

        private void btnBatalFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        public void PopulateForm(M_Presensi karyawan)
        {
            tbIDAKUNFiturPresensiKaryawan.Text = karyawan.id_akun.ToString();
            tbIDSHIFTFiturPresensiKaryawan.Text = karyawan.id_shift.ToString();
            dtpFiturPresensiKaryawan.Value = karyawan.waktu_presensi;
            IsEditMode = true;
            idPresensi = karyawan.id_presensi;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnSelesaiFiturPresensiKaryawan.Text = IsEditMode ? "Update" : "Add";
        }
        
    }
}
