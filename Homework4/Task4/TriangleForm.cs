using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputTriangle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                equilateralTriangle = new EquilateralTriangle(Convert.ToInt32(InputSide.Text));
            }
            catch (Exception ex)
            {
                OutPut.Text = ex.ToString();
            }
            
        }

        private EquilateralTriangle equilateralTriangle;

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void ProccesTriangle_Click(object sender, EventArgs e)
        {
            if(equilateralTriangle != null)
            {
                OutPut.Text = "Perimetr: " + equilateralTriangle.GetPerimetr() + " Square: " +
                equilateralTriangle.GetSquare();
            }
            else
            {
                OutPut.Text = "Input correct side";
            }
        }
    }
}
