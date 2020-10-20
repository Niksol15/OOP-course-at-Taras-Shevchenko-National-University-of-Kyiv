using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace MyExel
{
    class NullCellException : Exception { }
    class Cell: DataGridViewTextBoxCell
    {
        public Cell(DataGridViewCell parent)
        {
            _parent = parent;
            _name = cellToName(parent);
        }
        private string cellToName(DataGridViewCell cell)
        {
            return "R" + (cell.RowIndex + 1) + "C" + (cell.ColumnIndex + 1);
        }
        private List<Cell> cellsIDependOn = new List<Cell>();
        private HashSet<Cell> cellsDependOnMe = new HashSet<Cell>();
        private string _name;
        private string _value = "";
        private string _expression = "";
        private DataGridViewCell _parent;
        public string Name
        {
            get { return _name; }
        }
        public string Expression
        {
            get { return _expression;  }
        }
        private static bool stringToBool(string str)
        {
            try
            {
                if (str.Length == 0)
                {
                    return false;
                }
                double d = Convert.ToDouble(str);
                if(d == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool BoolValue
        {
            get { return stringToBool(_value); }
        }

        public new string Value
        {
            get { return _value;  }
        }
        public DataGridViewCell Parent
        {
            get { return _parent;  }
        }
        public void ProccesExpression(string expression)
        {
            bool isRecursion = false;
            _expression = expression;
            _parent.Tag = _expression;
            try
            {
                string res = Calculator.Evaluate(expression);
                List<Cell> Identifiers = CellManager.ListIdentifiersToListCells(Calculator.GetParsedIdentifiers());
                updateDependency(CellManager.ListIdentifiersToListCells(Calculator.GetParsedIdentifiers()));
                if (findCircle(Identifiers) == false)
                {
                    _value = res;
                    if (_value == "null")
                    {
                        _parent.Value = "null";
                    }
                    else
                    {
                        _parent.Value = (stringToBool(_value)).ToString();
                    }
                    cellsIDependOn = Identifiers;
                    _expression = expression;
                    _parent.Tag = _expression;
                }
                else
                {
                    MessageBox.Show("Ой, а вас рекурсія, будьте уважніші!");
                    _value = "";
                    _parent.Value = "";
                    _expression = "";
                    _parent.Tag = "";
                    cellsIDependOn.Clear();
                    isRecursion = true;
                }
            }
            catch (NullCellException)
            {
                MessageBox.Show("Ой, а ви використовуете комірочку зі значенням null, будьте уважніші!");
                _value = "null";
                _parent.Value = "null";
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, а у вас синтасична помилочка, будьте уважніші!");
                _value = "null";
                _parent.Value = "null";
            }
            finally
            {
                if(isRecursion == false)
                {
                    updateValue();
                }                           
            }
        }

        private void updateValue()
        {
            foreach(Cell cell in cellsDependOnMe)
            {
                cell.ProccesExpression(cell._expression);
            }
        }
        private bool findCircle(List<Cell> cells)
        {
            foreach(Cell cell in cells)
            {
                if (cell.findCircle(this))
                {
                    return true;
                }
            }
            return false;
        }
        private bool findCircle(Cell needed_cell)
        {
            if (this == needed_cell)
            {
                return true;
            }
            else
            {
                foreach (Cell cell in cellsIDependOn)
                {
                    if(cell.findCircle(needed_cell))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void updateDependency(List<Cell> cells)
        {
            foreach (Cell cell in cells)
            {
                cell.cellsDependOnMe.Add(this);
            }
        }
        public bool HasDependence()
        {
            return Convert.ToBoolean(cellsDependOnMe.Count);
        }
    }
}
