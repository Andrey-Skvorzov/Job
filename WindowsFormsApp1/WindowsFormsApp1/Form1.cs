using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       /* public double sinFisinDelta;
        public double lambda; */
        
       
        public Form1()
        {
          /*  double pi = 3.14, delta = 0.79, fi = 0.525, c = 27 * 10 * 10 * 10, q = 25.5 * 10 * 10 * 10, bg = 0.3, lg = 0.45, b = 0.68, l = 1.0, h0 = 0.25,
            rs = 360000 * 10 * 10 * 10, rb = 8500 * 10 * 10 * 10, rbt = 750 * 10 * 10 * 10, y = 17 * 10 * 10 * 10, y1 = 17 * 10 * 10 * 10; */
           IntermediateValues.sinFisinDelta = Math.Sin(Variables.delta) / Math.Sin(Variables.fi)/2;
           IntermediateValues.lambda = Variables.pi - Variables.delta - IntermediateValues.sinFisinDelta;
            
          /*  lambda = pi - delta - Math.Asin(Math.Sin(delta) / Math.Sin(fi))/ 2;
            test.Text = Convert.ToString(lambda);*/

            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            test.Text = Convert.ToString(IntermediateValues.lambda);
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
