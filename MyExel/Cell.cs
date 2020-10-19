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
            _value = "";
            _expression = "";
        }
        private string cellToName(DataGridViewCell cell)
        {
            return "R" + (cell.RowIndex + 1) + "C" + (cell.ColumnIndex + 1);
        }
        private List<Cell> cellsIDependOn;
        private List<Cell> cellsDependOnMe;
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
            _expression = expression;
            _parent.Tag = _expression;
            try
            {
                string res = Calculator.Evaluate(expression);
                List<string> Identifiers = Calculator.GetParsedIdentifiers();
                if (isRecursion(Identifiers) == false)
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
            
        }

        private bool isRecursion(List<string> identifiers)
        {
            return false;
        }
    }
}
