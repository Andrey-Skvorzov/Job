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

        public Form1()
        {
          IntermediateValuesOfFormulas.lambda = Math.Round((Variables.pi - Variables.delta - Math.Sin(Variables.delta) / Math.Sin(Variables.fi) / 2),2); /* 1,64 */
          Variables.alpha1 = Math.Round(2 * IntermediateValuesOfFormulas.lambda + Variables.fi,3); /* 3,805 */
          Variables.alpha2 = Math.Round ( 2 * IntermediateValuesOfFormulas.lambda - Variables.fi,3); /* 2,755 */
          IntermediateValuesOfFormulas.mi0 = Math.Round(( 1 + Math.Sin(Variables.alpha0)) / Math.Cos(Variables.alpha0),3); /* 1,735 */
          IntermediateValuesOfFormulas.mi1 = Math.Round((1 + Math.Sin(Variables.alpha1)) / Math.Cos(Variables.alpha1), 3); /* -0,488 */
          IntermediateValuesOfFormulas.mi2 = Math.Round((1 + Math.Sin(Variables.alpha2)) / Math.Cos(Variables.alpha2), 3); /* -1,487 */
          IntermediateValuesOfFormulas.bigE = Math.Round(Math.Pow(Variables.e, IntermediateValuesOfFormulas.lambda * Math.Tan(Variables.fi)),3); /* 2,585 */
          

            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*  test.Text = Convert.ToString(Math.Round(IntermediateValuesOfFormulas.lambda,2)); */
            test.Text = Convert.ToString(IntermediateValuesOfFormulas.bigE);
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
