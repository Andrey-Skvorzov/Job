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
            double delta = 111.11; /* дельта в радианах */ /* посмотреть как переводить в радианы в коде*/
            double fi = 0.525; /* угол внутреннего трения в радианах*/
            double c = 27 * 10 ^ 3; /* удельное сцепление в Паскалях*/
            double q = 25.5 * 10*10*10; /* пригрузка фундамента в Паскалях*/ /* нельзя в doubl и int */
            double bg = 0.3; /* ширина жесткой части фундамента в метрах*/
            double lg = 0.45; /* длина жесткой части фундамента в метрах*/
            double b = 0.68; /* ширина плитной части фундамента в метрах */
            double l = 1.0; /* длина плитной части фундамента в метрах */
            double h0 = 0.25; /* рабочая высота плитной части фундамента в метрах */
            double rs = 360000 * 10 ^ 3; /* расчетное сопротивление арматуры растяжению в паскалях */
            double rb = 8500 * 10 ^ 3; /* расчетное сопротивление бетона расжатию в паскалях */
            double rbt = 750 * 10 ^ 3; /* расчетное сопротивление бетона напряжению в паскалях */

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
