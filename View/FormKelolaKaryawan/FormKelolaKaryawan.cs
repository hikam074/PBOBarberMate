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

namespace PBOBarberMate.View.FormKelolaKaryawan
{
    public partial class FormKelolaKaryawan : Form
    {
        public FormKelolaKaryawan()
        {
            InitializeComponent();
            //MenampilkanKehadiranKaryawan();
        }
        public void MenampilkanKehadiranKaryawan()
        {
            //    try
            //    {
            //        dataGridViewKelolaKaryawan.AllowUserToAddRows = false;
            //        DataTable kehadiranKaryawan = PresensiContext.All();
            //        if (kehadiranKaryawan == null)
            //        {
            //            MessageBox.Show("Error: Gagal Mengambil Presensi Karyawan");
            //            return;
            //        }
            //        DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            //        {
            //            Name = "Update",
            //            HeaderText = "Update",
            //            Text = "Edit",
            //            UseColumnTextForButtonValue = true
            //        };
            //        dataGridViewKelolaKaryawan.Columns.Add(updateButtonColumn);

            //        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            //        {
            //            Name = "Delete",
            //            HeaderText = "Delete",
            //            Text = "Delete",
            //            UseColumnTextForButtonValue = true
            //        };
            //        dataGridViewKelolaKaryawan.Columns.Add(deleteButtonColumn);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error dalam Load Kehadiran Karyawan: {ex.Message}\n{ex.StackTrace}");
            //    }
        }

    private void dataGridViewKelolaKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //    if (e.RowIndex < 0) return;

        //    if (e.ColumnIndex == dataGridViewKelolaKaryawan.Columns["Update"].Index)
        //    {
        //        try
        //        {
        //            int presensiId = Convert.ToInt32(dataGridViewKelolaKaryawan.Rows[e.RowIndex].Cells["id"].Value);

        //            DataTable presensiData = PresensiContext.getDataPresensiById(presensiId);

        //            if (presensiData.Rows.Count > 0)
        //            {
        //                DataRow row = presensiData.Rows[0];
        //                M_Presensi mahasiswa = new M_Presensi
        //                {
        //                    id_presensi = (int)row["id"],
        //                };

        //                this.Hide();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //    else if (e.ColumnIndex == dataGridViewKelolaKaryawan.Columns["Delete"].Index)
        //    {
        //        int mahasiswaId = Convert.ToInt32(dataGridViewKelolaKaryawan.Rows[e.RowIndex].Cells["id"].Value);
        //        PresensiContext.DeletePresensi(mahasiswaId);
        //        MenampilkanKehadiranKaryawan();
        //    }
    }
    }
}
