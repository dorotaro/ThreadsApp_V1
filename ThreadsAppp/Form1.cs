using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ThreadsAppp.ThreadGeneration;

namespace ThreadsAppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var selectedValue = Int32.Parse(intValueSelection.SelectedItem.ToString());

            for (int i = 0; i < selectedValue; i++)
            {
                ThreadGenerator();
            }

            Form2.ActiveForm.Activate();
        }

        private void intValueSelection_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
