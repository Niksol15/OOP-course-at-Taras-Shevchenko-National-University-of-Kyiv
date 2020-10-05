using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class OutputRhombus : Form
    {
        public OutputRhombus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitialA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] diagonals = InputDiagonals.Text.Split(' ');
            if(diagonals.Length != 2)
            {
                OutputRhomb.Text = "Incorrect input";
            }
            try
            {
                rhombus = new Rhombus(Convert.ToInt32(diagonals[0]), Convert.ToInt32(diagonals[1]));
            }
            catch (Exception exception)
            {
                OutputRhomb.Text = exception.Message;
                rhombus = null;
            }
            if (rhombus != null)
            {
                OutputRhomb.Text = "Perimeter: " + rhombus.GetPerimetеr() + "\nArea: " +
                    rhombus.GetArea();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void InitialD1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputCircle_Click(object sender, EventArgs e)
        {

        }


        private Rhombus rhombus;
        private Circle circle;

        private void ProcessCircle_Click(object sender, EventArgs e)
        {
            if(InputRadius.Text.Length == 0)
            {
                OutputCircle.Text = "Input radius";
            }
            try
            {
                circle = new Circle(Convert.ToInt32(InputRadius.Text));
            }
            catch(Exception exception)
            {
                OutputCircle.Text = exception.Message;
                circle = null;
            }
            if(circle != null)
            {
                OutputCircle.Text = "Perimeter: " + circle.GetPerimetеr() + "\nArea: " +
                    circle.GetArea();
            }
        }
    }
}
