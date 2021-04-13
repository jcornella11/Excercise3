using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inchesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inchesPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void centimeterPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void centimeterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inchesMeasurment;
            double centimeterMeasurment;
            double conversionFactor = 2.54;

            inchesMeasurment = double.Parse(inchesTextBox.Text);
            centimeterMeasurment = inchesMeasurment * conversionFactor;
            centimeterTextBox.Text = centimeterMeasurment.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
