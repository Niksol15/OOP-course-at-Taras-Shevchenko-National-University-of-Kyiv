using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTriangle_TextChanged(object sender, EventArgs e)
        {
            string[] parametrs = InputTriangle.Text.Split(' ');
            try
            {
                rightTriangle = new RightTriangle(Convert.ToInt32(parametrs[0]),
                    Convert.ToInt32(parametrs[1]));
            }
            catch (Exception ex)
            {
                OutputRightTriangle.Text = ex.Message;
                rightTriangle = null;
            }
            try
            {
                isoscelesTriangle = new IsoscelesTriangle(Convert.ToInt32(parametrs[0]),
                    Convert.ToDouble(parametrs[2]));
            }
            catch (Exception ex)
            {
                OutputIsosceles.Text = ex.Message;
                isoscelesTriangle = null;
            }

            if(rightTriangle != null)
            {
                OutputRightTriangle.Text = "Perimetr: " + rightTriangle.GetPerimetеr() +
                    "\nArea: " + rightTriangle.GetArea();
            }
            if (isoscelesTriangle != null)
            {
                OutputIsosceles.Text = "Perimetr: " + isoscelesTriangle.GetPerimetеr() +
                    "\nArea: " + isoscelesTriangle.GetArea();
            }
        }

        private RightTriangle rightTriangle;
        private IsoscelesTriangle isoscelesTriangle;
    }
}
