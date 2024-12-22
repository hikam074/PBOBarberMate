using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBOBarberMate.App.Context;
using PBOBarberMate.App.Model;

namespace PBOBarberMate.View.FormKelolaKaryawan
{
    public partial class FiturTambahKaryawan : Form
    {
        public bool IsUbahKaryawan { get; set; } = false;
        public int IdAkun { get; set; }
        public string Nama_Karyawan { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public FiturTambahKaryawan()
        {
            InitializeComponent();
        }

        private void btnSelesaiFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            Nama_Karyawan = textBox1.Text;
            Email = textBox2.Text;
            Password = textBox3.Text;
            if (IsUbahKaryawan)
            {

                KaryawanContext.UpdateKaryawan(Nama_Karyawan, Email, Password, IdAkun);
                MessageBox.Show("Karyawan berhasil diupdate");
                this.Hide();

            }
            else
            {
                KaryawanContext.AddKaryawan(Nama_Karyawan, Email, Password);
                MessageBox.Show("Karyawan berhasil ditambahkan");
                this.Hide();


            }

        }
        public void PopulateForm(string Nama_karyawan, string Email, string Password, int idAkun)
        {

            textBox1.Text = Nama_karyawan;
            textBox2.Text = Email;
            textBox3.Text = Password;
            IdAkun = idAkun;

        }

        private void btnBatalFiturPresensiKaryawan_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
