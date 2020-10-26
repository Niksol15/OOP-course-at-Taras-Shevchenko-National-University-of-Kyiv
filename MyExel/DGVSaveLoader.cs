using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyExel
{
    static class DGVSaveLoader
    {
        private const char SEPARATE_SYMBOL = '|';
        public static DataTable CreateDataTableFromDGV(DataGridView dgv)
        {
            DataTable dataTable = new DataTable("data");
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dataTable.Columns.Add(column.Index.ToString());
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dgv.ColumnCount; ++i)
                {
                    dataRow[i] = row.Cells[i].Tag;
                }
            }
            return dataTable;
        }

        public static bool SaveDGV(DataGridView dgv, string file_path)
        {
            try
            {
                StreamWriter tw = new StreamWriter(file_path, false, Encoding.Default);
                tw.WriteLine(dgv.RowCount);
                tw.WriteLine(dgv.ColumnCount);
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    bool isFirst = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (isFirst)
                        {
                            isFirst = false;
                        }
                        else
                        {
                            tw.Write(SEPARATE_SYMBOL);
                        }
                        tw.Write(cell.Tag);
                    }
                    tw.Write("\n");
                }
                tw.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при збереженні файла");
                return false;
            }
        }
        public static bool OpenDVG(DataGridView dgv, string file_path)
        {
            try
            {
                StreamReader tr = new StreamReader(file_path);
                int rowCounter = Convert.ToInt32(tr.ReadLine());
                int columnCounter = Convert.ToInt32(tr.ReadLine());
                dgv.ColumnCount = columnCounter;
                dgv.RowCount = rowCounter;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int i = 0;
                    string rowString = tr.ReadLine();
                    string[] cells = rowString.Split(SEPARATE_SYMBOL);
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Tag = cells[i++];
                    }
                }
                CellManager.RefreshDGV(dgv);
                tr.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при відкритті файла, спробуйте ще раз");
                return false;
            }
        }
    }
}
