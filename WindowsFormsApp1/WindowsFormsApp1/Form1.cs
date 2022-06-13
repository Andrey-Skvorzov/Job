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
            IntermediateValuesOfFormulas.lambda = Math.Round((Variables.pi - Variables.delta - Math.Asin(Math.Sin(Variables.delta) / Math.Sin(Variables.fi))) / 2, 3); /* 0.553 */
            Variables.alpha1 = Math.Round(2 * IntermediateValuesOfFormulas.lambda + Variables.fi, 3); /* 1,631 */
            Variables.alpha2 = Math.Round(2 * IntermediateValuesOfFormulas.lambda - Variables.fi, 3); /* 0,581 */
            IntermediateValuesOfFormulas.mi0 = Math.Round((1 + Math.Sin(Variables.alpha0)) / Math.Cos(Variables.alpha0), 3); /* 1,735 */
            IntermediateValuesOfFormulas.mi1 = Math.Round((1 + Math.Sin(Variables.alpha1)) / Math.Cos(Variables.alpha1), 3); /* -33,211 */
            IntermediateValuesOfFormulas.mi2 = Math.Round((1 + Math.Sin(Variables.alpha2)) / Math.Cos(Variables.alpha2), 3); /* 1,853 */
            IntermediateValuesOfFormulas.bigE = Math.Round(Math.Pow(Variables.e, IntermediateValuesOfFormulas.lambda * Math.Tan(Variables.fi)), 3); /* 1,378 */
            IntermediateValuesOfFormulas.bigI = Math.Round((Math.Cos(IntermediateValuesOfFormulas.lambda) - (IntermediateValuesOfFormulas.mi0 * Math.Sin(IntermediateValuesOfFormulas.lambda))) * IntermediateValuesOfFormulas.bigE, 3); /* -0,083 */
            IntermediateValuesOfFormulas.a = Math.Round((1 - IntermediateValuesOfFormulas.bigI) / (IntermediateValuesOfFormulas.bigI * IntermediateValuesOfFormulas.mi1 - IntermediateValuesOfFormulas.mi0), 3); /* 1,06 */
            IntermediateValuesOfFormulas.bigF = Math.Round(1 - (IntermediateValuesOfFormulas.mi2 * Math.Tan(Variables.delta)), 3); /* -0,071 */
            IntermediateValuesOfFormulas.bigR = Math.Round((1 + (IntermediateValuesOfFormulas.mi1 * IntermediateValuesOfFormulas.a)) * (1 + Math.Sin(Variables.fi) - (2 * Math.Pow(Math.Sin(IntermediateValuesOfFormulas.lambda), 2))), 3); /* -32,475 */
            IntermediateValuesOfFormulas.bigNy = Math.Round((1 / (4 * IntermediateValuesOfFormulas.bigF)) * (((Math.Cos(Variables.alpha1) * ((1 / Math.Sin(Variables.fi)) - IntermediateValuesOfFormulas.mi0 * (Math.Pow(IntermediateValuesOfFormulas.bigE, 2)) * ((1 / Math.Tan(Variables.fi)) + IntermediateValuesOfFormulas.a))) / IntermediateValuesOfFormulas.bigR) + (2 * (Math.Pow(Math.Cos(IntermediateValuesOfFormulas.lambda), 2) / (Math.Cos(Variables.fi))) - IntermediateValuesOfFormulas.mi0)), 3); /* 0,263 */
            IntermediateValuesOfFormulas.bigNq = Math.Round((IntermediateValuesOfFormulas.bigI / (IntermediateValuesOfFormulas.bigF * IntermediateValuesOfFormulas.bigR) * Math.Cos(Variables.fi) * IntermediateValuesOfFormulas.mi1) * (1 + (IntermediateValuesOfFormulas.mi0 * IntermediateValuesOfFormulas.a)), 3); /* 2,937 */
            IntermediateValuesOfFormulas.bigNc = Math.Round((IntermediateValuesOfFormulas.bigNq - 1) / Math.Tan(Variables.fi), 3); /* 3,344 */
            IntermediateValuesOfFormulas.bigA = Math.Round((1 + Math.Sin(Variables.fi)) / (1 - Math.Sin(Variables.fi)), 3); /* 3,01 */
            IntermediateValuesOfFormulas.bigC = Math.Round(2 * Variables.c * Math.Cos(Variables.fi) / (1 - Math.Sin(Variables.fi)), 3); /*93682,26 */
            IntermediateValuesOfFormulas.bigP = Math.Round(IntermediateValuesOfFormulas.bigA * Math.Pow(Variables.e, Variables.pi * ((IntermediateValuesOfFormulas.bigA - 1) / (2 * Math.Sqrt(IntermediateValuesOfFormulas.bigA)))) * (Variables.q + (IntermediateValuesOfFormulas.bigC / (IntermediateValuesOfFormulas.bigA - 1))) - (IntermediateValuesOfFormulas.bigC / (IntermediateValuesOfFormulas.bigA - 1)), 3);  /* 1292811,141 */
            IntermediateValuesOfFormulas.bigNp = Math.Round(IntermediateValuesOfFormulas.bigP * Variables.l * Variables.b, 3); /* 879111,576 */
            IntermediateValuesOfFormulas.formulh0 = Math.Round(-0.25 * (Variables.bg + Variables.lg) + (0.5 * Math.Sqrt(IntermediateValuesOfFormulas.bigNp / (Variables.rbt + IntermediateValuesOfFormulas.bigP))), 3); /* 0,141 */
            IntermediateValuesOfFormulas.forceF = Math.Round(Variables.rbt * (2 * Math.Sqrt(2)) * IntermediateValuesOfFormulas.formulh0, 3); /* 299106,168 */
            IntermediateValuesOfFormulas.bigN = Math.Round(IntermediateValuesOfFormulas.forceF + (IntermediateValuesOfFormulas.bigP * (Variables.b + (2 * IntermediateValuesOfFormulas.formulh0))), 3); /* 1542790,486 */
            IntermediateValuesOfFormulas.bx = Math.Round((IntermediateValuesOfFormulas.forceF + (2 * IntermediateValuesOfFormulas.bigP * IntermediateValuesOfFormulas.formulh0) - (2 * Variables.bg * Variables.q)) / (2 * (IntermediateValuesOfFormulas.bigP - Variables.q)), 3); /* 0,256 */
            IntermediateValuesOfFormulas.bigMultb = Math.Round((0.5 * IntermediateValuesOfFormulas.bigP * Math.Pow(IntermediateValuesOfFormulas.bx, 2)) + (0.5 * Variables.q * (Math.Pow(Variables.bg, 2) - Math.Pow(IntermediateValuesOfFormulas.bx, 2))), 3); /* 42674,751 */
            Answers.bigAsb = Math.Round(((Variables.rs * IntermediateValuesOfFormulas.formulh0) - (Math.Sqrt((Math.Pow(Variables.rs * IntermediateValuesOfFormulas.formulh0, 2)) - (2 * IntermediateValuesOfFormulas.bigMultb * (Math.Pow(Variables.rs, 2) / Variables.rb))))) / (Math.Pow(Variables.rs, 2) / Variables.rb), 5); /* 0,00099 */
            IntermediateValuesOfFormulas.bigNHard = Math.Round(IntermediateValuesOfFormulas.forceF + (IntermediateValuesOfFormulas.bigP * (Variables.l + (2 * IntermediateValuesOfFormulas.formulh0))), 3); /* 1956490,051 */
            IntermediateValuesOfFormulas.bigLxHard = Math.Round((IntermediateValuesOfFormulas.forceF + (2 * IntermediateValuesOfFormulas.bigP * IntermediateValuesOfFormulas.formulh0) - (2 * Variables.l * Variables.q)) / (2 * (IntermediateValuesOfFormulas.bigP - Variables.q)), 3); /* 0,242 */
            IntermediateValuesOfFormulas.bigMultbHard = Math.Round((0.5 * IntermediateValuesOfFormulas.bigP * Math.Pow(IntermediateValuesOfFormulas.bigLxHard, 2)) + (0.5 * Variables.q * (Math.Pow(Variables.l, 2) - Math.Pow(IntermediateValuesOfFormulas.bigLxHard, 2))), 3); /* 49859.405 */
            IntermediateValuesOfFormulas.bigAsLHard = Math.Round(((Variables.rs * IntermediateValuesOfFormulas.formulh0) - (Math.Sqrt((Math.Pow(Variables.rs * IntermediateValuesOfFormulas.formulh0, 2)) - (2 * IntermediateValuesOfFormulas.bigMultbHard * (Math.Pow(Variables.rs, 2) / Variables.rb))))) / (Math.Pow(Variables.rs, 2) / Variables.rb), 5); /* 0,0012 */
            IntermediateValuesOfFormulas.bigMb = Math.Round(0.9 * Answers.bigAsb * Variables.rs * IntermediateValuesOfFormulas.formulh0, 3); /* 45227.16 */
            IntermediateValuesOfFormulas.bigMl = Math.Round(0.9 * IntermediateValuesOfFormulas.bigAsLHard * Variables.rs * IntermediateValuesOfFormulas.formulh0, 3); /* 54820,8 */
            IntermediateValuesOfFormulas.bigMub = Math.Round(2 * IntermediateValuesOfFormulas.bigMb / (IntermediateValuesOfFormulas.bigNy * Variables.y * Math.Pow(Variables.bg, 3) * Variables.lg), 3); /* 1665,131 */
            IntermediateValuesOfFormulas.bigMul = Math.Round(2 * IntermediateValuesOfFormulas.bigMl / (IntermediateValuesOfFormulas.bigNy * Variables.y * Math.Pow(Variables.bg, 2) * Math.Pow(Variables.lg, 2)), 3); /* 1345,56*/
            IntermediateValuesOfFormulas.infAlpha = Math.Round(IntermediateValuesOfFormulas.bigNq * Variables.y1 * Variables.d / (IntermediateValuesOfFormulas.bigNy * Variables.y * Variables.bg), 3); /* 967832,7 */
            IntermediateValuesOfFormulas.infBi = Math.Round(IntermediateValuesOfFormulas.bigNc * Variables.c / (IntermediateValuesOfFormulas.bigNy * Variables.y * Variables.bg), 3); /* 67,314 */
            IntermediateValuesOfFormulas.ita = Math.Round(Variables.bg / Variables.lg, 3); /* 0,667 */
            IntermediateValuesOfFormulas.widthB1 = Math.Round(Variables.bg * (1 + 2 * IntermediateValuesOfFormulas.epselentB), 3); /* 0,3 */
            IntermediateValuesOfFormulas.lengthL1 = Math.Round(Variables.bg * (1 + 2 * IntermediateValuesOfFormulas.epselentB), 3); /* 0,3 */
            if (IntermediateValuesOfFormulas.widthB1 > Variables.b)
                IntermediateValuesOfFormulas.widthB1 = Variables.b; /* 0,68 */

            if (IntermediateValuesOfFormulas.lengthL1 > Variables.l)
                IntermediateValuesOfFormulas.lengthL1 = Variables.l; /* 1 */
            IntermediateValuesOfFormulas.ita1 = Math.Round(IntermediateValuesOfFormulas.lengthL1 / IntermediateValuesOfFormulas.widthB1, 3); /* 1 если if не выполнился */
            IntermediateValuesOfFormulas.epselentY = Math.Round(1 - (0.25 / IntermediateValuesOfFormulas.ita1), 3); /* 0,75 */
            IntermediateValuesOfFormulas.epselentQ = Math.Round(1 + (1.5 / IntermediateValuesOfFormulas.ita1), 3); /* 2,5 */
            IntermediateValuesOfFormulas.epselentC = Math.Round(1 + (0.3 / IntermediateValuesOfFormulas.ita1), 3); /* 1,3 */
            Answers.bigPult = Math.Round(IntermediateValuesOfFormulas.widthB1 * IntermediateValuesOfFormulas.lengthL1 * (IntermediateValuesOfFormulas.bigNy * IntermediateValuesOfFormulas.epselentY * IntermediateValuesOfFormulas.widthB1 * Variables.y + (IntermediateValuesOfFormulas.bigNq * IntermediateValuesOfFormulas.epselentQ * Variables.y1 * Variables.d) + (IntermediateValuesOfFormulas.bigNc * IntermediateValuesOfFormulas.epselentC * Variables.c)), 3);  /* 292095304.234 Н/м */

            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            firstAnswer.Text = Convert.ToString(Answers.bigAsb);
            secondAnswer.Text = Convert.ToString(Answers.bigPult);
        }

    }
}
