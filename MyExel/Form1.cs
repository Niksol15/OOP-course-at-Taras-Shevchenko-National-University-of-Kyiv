using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExel
{
    public partial class MyExel : Form
    {
        public MyExel()
        {
            InitializeComponent();
            InitializeDGV();
            InitializeCells();

        }
        private const int MAX_COLUMN = 10;
        private const int MAX_ROW = 12;
        private const int ROW_HEADERS_WIDTH = 80;
        private void InitializeDGV()
        {
            DGVTable.ColumnCount = MAX_COLUMN;
            DGVTable.RowCount = MAX_ROW;
            FillHeadrs();
            DGVTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVTable.RowHeadersWidth = ROW_HEADERS_WIDTH;
            DGVTable.ReadOnly = true;
            DGVTable.MultiSelect = false;
            DGVTable.AllowUserToAddRows = false;
        }
        private void InitializeCells()
        {
            foreach(DataGridViewRow row in DGVTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = "";
                    cell.Tag = "";
                    CellManager.AddCell(cell);
                }
            }
        }

        private void FillHeadrs()
        {
            foreach(DataGridViewColumn col in DGVTable.Columns)
            {
                col.HeaderText = "C" + (col.Index + 1);
            }
            foreach (DataGridViewRow row in DGVTable.Rows)
            {
                row.HeaderCell.Value = "R" + (row.Index + 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteRowBotton_Click(object sender, EventArgs e)
        {
            if(DGVTable.Rows.Count == 1)
            {
                MessageBox.Show("Не можно выдаляти останній рядок");
            }
            else
            {
                if (isLastRowHasDependence())
                {
                    MessageBox.Show("Не можно выдаляти рядок, від нього залежать клітинки у таблиці");
                }
                else
                {
                    DGVTable.Rows.RemoveAt(DGVTable.RowCount - 1);
                }
            }
        }

        private bool isLastRowHasDependence()
        {
            foreach(DataGridViewCell cell in DGVTable.Rows[DGVTable.Rows.Count - 1].Cells)
            {
                if(cell == null)
                {
                    return false;
                }
                Cell _cell = CellManager.DGVCellToCell(cell);
                if(_cell == null)
                {
                    return false;
                }
                if (_cell.HasDependence())
                {
                    return true;
                }
            }
            return false;
        }
        private void DGVTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteColumnBotton_Click(object sender, EventArgs e)
        {
            if (DGVTable.Columns.Count == 1)
            {
                MessageBox.Show("Не можно выдаляти останній cтовпчик");
            }
            else
            {
                if (isLastColumnHasDependence())
                {
                    MessageBox.Show("Не можно выдаляти стовпчик, від нього залежать клітинки у таблиці");
                }
                else
                {
                    DGVTable.Columns.RemoveAt(DGVTable.ColumnCount - 1);
                }
            }
        }
        private bool isLastColumnHasDependence()
        {
            foreach (DataGridViewRow row in DGVTable.Rows)
            {
                DataGridViewCell cell = row.Cells[DGVTable.ColumnCount - 1];
                if (cell == null)
                {
                    return false;
                }
                if (CellManager.DGVCellToCell(cell).HasDependence())
                {
                    return true;
                }
            }
            return false;
        }

        private void ProccesInput(object sender, EventArgs e)
        {
            DataGridViewCell cell = DGVTable.CurrentCell;
            if (cell != null)
            {
                CellManager.ProccesExpression(cell, InputBox.Text);
            }
        }
        private void ApplyBottom_Click(object sender, EventArgs e)
        {
            ProccesInput(sender, e);
        }

        private void DGVTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InputBox.Text = DGVTable.CurrentCell.Tag.ToString();
        }

        private void AddRowBotton_Click(object sender, EventArgs e)
        {

            DataGridViewRow addedRow = new DataGridViewRow();            
            foreach (DataGridViewCell cell in addedRow.Cells)
            {
                cell.Value = "";
                cell.Tag = "";
                CellManager.AddCell(cell);
            }
            DGVTable.Rows.Add(addedRow);
            FillHeadrs();
        }

        private void AddColumnBotton_Click(object sender, EventArgs e)
        {
            DGVTable.Columns.Add(new DataGridViewColumn(DGVTable.Rows[0].Cells[0]));
            FillHeadrs();
            foreach(DataGridViewRow row in DGVTable.Rows)
            {
                CellManager.AddCell(row.Cells[DGVTable.ColumnCount - 1]);
            }           
        }

        private void MyExel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("А ви точно-точно хочете вийти?", "Точно?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                //e.Cancel = true;
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
