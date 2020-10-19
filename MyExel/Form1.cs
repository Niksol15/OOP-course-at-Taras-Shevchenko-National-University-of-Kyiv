using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void DGVTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteColumnBotton_Click(object sender, EventArgs e)
        {

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
    }
}
