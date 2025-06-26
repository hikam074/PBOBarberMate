using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace PBOBarberMate.App.Utils
{
    public static class DataGridViewSorter
    {
        private static string currentSortedColumn = "";
        private static SortOrder currentSortOrder = SortOrder.None;

        public static void Sort<T>(DataGridView dataGridView, DataGridViewCellMouseEventArgs e, ref List<T> dataSource)
        {
            string columnName = dataGridView.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(columnName)) return;

            // Tentukan urutan sorting
            if (currentSortedColumn == columnName)
            {
                // Toggle sort order jika kolom sama
                currentSortOrder = currentSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Jika kolom berubah, set ke ascending
                currentSortedColumn = columnName;
                currentSortOrder = SortOrder.Ascending;
            }

            // Lakukan sorting berdasarkan urutan
            if (currentSortOrder == SortOrder.Ascending)
            {
                dataSource = dataSource.OrderBy(k => GetPropertyValue(k, columnName)).ToList();
            }
            else
            {
                dataSource = dataSource.OrderByDescending(k => GetPropertyValue(k, columnName)).ToList();
            }

            // Perbarui DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataSource;
        }

        private static object GetPropertyValue<T>(T item, string propertyName)
        {
            return typeof(T).GetProperty(propertyName)?.GetValue(item, null);
        }
    }
}
