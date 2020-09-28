using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Forms
{
    public partial class Form1 : Form
    {
        Random generator = new Random();

        public Form1()
        {
            InitializeComponent();
        }

       

        

        private void btnIntegerSubmit_Click(object sender, EventArgs e)
        {
            int minimum = Convert.ToInt32(min.Value);
            int maximum = Convert.ToInt32(max.Value);
            int randomInt = generator.Next(minimum, maximum + 1);
            lblRandomNumber.Text = randomInt.ToString();

        }

        private void minValue_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void maxValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void lblMinValue_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxValue_Click(object sender, EventArgs e)
        {

        }

        private void lblRandomNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnDblSubmit_Click(object sender, EventArgs e)
        {
            double minimum = Convert.ToDouble(min.Value);
            double maximum = Convert.ToDouble(max.Value);
            double randomDouble = generator.NextDouble() * (maximum - minimum) + minimum;
            lblRandomNumber.Text = randomDouble.ToString();

        }
    }

    }