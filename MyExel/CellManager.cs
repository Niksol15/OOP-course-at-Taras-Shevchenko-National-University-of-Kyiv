using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyExel
{
    static class CellManager
    {
        private static Dictionary<DataGridViewCell, Cell> _dgvCellToCell = new Dictionary<DataGridViewCell, Cell>();
        private static Dictionary<string, Cell> _identifierToCell = new Dictionary<string, Cell>();
        public static void AddCell(DataGridViewCell dgvCell)
        {
            Cell cell = new Cell(dgvCell);
            _dgvCellToCell.Add(dgvCell, cell);
            _identifierToCell.Add(cell.Name, cell);
        }
        public static void DeleteCell(DataGridViewCell dgvCell)
        {
            if(dgvCell != null && _dgvCellToCell.ContainsKey(dgvCell))
            {
                Cell cellToDelete = _dgvCellToCell[dgvCell];
                _dgvCellToCell.Remove(dgvCell);
                _identifierToCell.Remove(cellToDelete.Name);
            }
        }
        public static Cell DGVCellToCell(DataGridViewCell dgvCell)
        {
            Cell cell;
            if (_dgvCellToCell.TryGetValue(dgvCell, out cell))
            {
                return cell;
            }
            else
            {
                return null;
            }
        }
        
        public static bool IdentifierToBoolValue(string identifier)
        {
            Cell cell;
            if (_identifierToCell.TryGetValue(identifier, out cell))
            {
                return cell.BoolValue;
            }
            return false;
        }

        public static string IdentifierToStringValue(string identifier)
        {
            Cell cell;
            if (_identifierToCell.TryGetValue(identifier, out cell))
            {
                return cell.Value;
            }
            return "null";
        }
        public static List<Cell> ListIdentifiersToListCells(List<string> strings)
        {
            List<Cell> cells = new List<Cell>();
            foreach(string str in strings)
            {
                cells.Add(_identifierToCell[str]);
            }
            return cells;
        }
        public static void ProccesExpression(DataGridViewCell dgvCell, string expression)
        {
            Cell cell = DGVCellToCell(dgvCell);
            if(cell != null)
            {
                cell.ProccesExpression(expression);
            }        
        }

        public static void RefreshDGV(DataGridView dgv)
        {
            _dgvCellToCell.Clear();
            _identifierToCell.Clear();
            foreach(DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell dgvCell in row.Cells)
                {
                    dgvCell.Value = "";
                    AddCell(dgvCell);
                }
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell dgvCell in row.Cells)
                {
                    if(dgvCell.Tag.ToString() != "")
                    {
                        ProccesExpression(dgvCell, dgvCell.Tag.ToString());
                    }
                }
            }
        }
    }
}
