using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyExel
{
    class NullCellException : Exception { }
    class Cell: DataGridViewCell
    {
        public Cell(DataGridViewCell parent, bool proccessNow = false)
        {
            _parent = parent;
            _name = cellToName(parent);
            _expression = parent.Tag.ToString();
            if (parent.Tag.ToString() != "" && proccessNow)
            {
                ProccesExpression(_expression);
            }
            else 
            {
                _value = "";
            }
        }
        private string cellToName(DataGridViewCell cell)
        {
            return "R" + (cell.RowIndex + 1) + "C" + (cell.ColumnIndex + 1);
        }
        private List<Cell> cellsIDependOn = new List<Cell>();
        private HashSet<Cell> cellsDependOnMe = new HashSet<Cell>();
        private string _name;
        private string _value;
        private string _expression;
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
            List<Cell> parsedCells = new List<Cell>();
            try
            {
                string res = Calculator.Evaluate(expression);
                parsedCells = CellManager.ListIdentifiersToListCells(Calculator.GetParsedIdentifiers());
                if (findCycle(parsedCells) == false)
                {
                    _value = res;
                    _parent.Value = (stringToBool(_value)).ToString();
                }
                else
                {
                    MessageBox.Show("Ой, а вас рекурсія, будьте уважніші!");
                    //clearCell();
                    isRecursion = true;
                }
            }
            catch (NullCellException)
            {
                MessageBox.Show("Ой, а ви використовуете комірочку зі значенням null, будьте уважніші!");
                setNullValue();
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, а у вас синтасична помилочка, будьте уважніші!");
                setNullValue();
            }
            finally
            {
                if(isRecursion == false)
                {
                    _expression = expression;
                    _parent.Tag = _expression;
                    updateDependency(parsedCells);
                    cellsIDependOn = parsedCells;
                    updateValue();
                }                           
            }
        }

        private void setNullValue() 
        {
            _value = "null";
            _parent.Value = "null";
        }

        private void clearCell()
        {
            _value = "";
            _parent.Value = "";
            _expression = "";
            _parent.Tag = "";
            cellsIDependOn.Clear();
        }
        private void updateValue()
        {
            List<Cell> temp = cellsDependOnMe.ToList<Cell>();
            for(int i = 0; i < temp.Count; ++i)
            {
                temp[i].ProccesExpression(temp[i].Expression);
            }
            /*
            foreach(Cell cell in cellsDependOnMe)
            {
                cell.ProccesExpression(cell.Expression);
            }
            */
        }
        private bool findCycle(List<Cell> cells)
        {
            foreach(Cell cell in cells)
            {
                if (cell.findCycle(this))
                {
                    return true;
                }
            }
            return false;
        }
        private bool findCycle(Cell needed_cell)
        {
            if (this == needed_cell)
            {
                return true;
            }
            else
            {
                foreach (Cell cell in cellsIDependOn)
                {
                    if(cell.findCycle(needed_cell))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void updateDependency(List<Cell> cells)
        {
            if (cells == cellsIDependOn)
            {
                return;
            }
            foreach(Cell cell in cellsIDependOn)
            {
                //if (!cells.Contains(cell))
                //{
                    cell.cellsDependOnMe.Remove(this);
                //}               
            }
            foreach (Cell cell in cells)
            {
                cell.cellsDependOnMe.Add(this);
            }
        }
        public bool HasDependence()
        {
            return cellsDependOnMe.Count != 0;
        }
    }
}
