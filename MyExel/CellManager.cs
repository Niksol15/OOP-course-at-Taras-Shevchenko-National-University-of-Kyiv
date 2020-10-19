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
            return _identifierToCell[identifier].BoolValue;
        }

        public static string IdentifierToStringValue(string identifier)
        {
            return _identifierToCell[identifier].Value;
        }
        public static void ProccesExpression(DataGridViewCell dgvCell, string expression)
        {
            Cell cell = DGVCellToCell(dgvCell);
            if(cell != null)
            {
                cell.ProccesExpression(expression);
            }        
        }
    }
}
