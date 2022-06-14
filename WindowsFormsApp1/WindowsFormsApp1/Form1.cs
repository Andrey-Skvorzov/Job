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
             
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Variables.delta = Convert.ToDouble(deltaInput.Text);
                Variables.fi = Convert.ToDouble(fiInput.Text);
                Variables.d = Convert.ToDouble(dInput.Text);
                Variables.c = Convert.ToDouble(cInput.Text);
                Variables.q = Convert.ToDouble(qInput.Text);
                Variables.bg = Convert.ToDouble(bgInput.Text);
                Variables.lg = Convert.ToDouble(lgInput.Text);
                Variables.b = Convert.ToDouble(bInput.Text);
                Variables.l = Convert.ToDouble(lInput.Text);
                Variables.h0 = Convert.ToDouble(h0Input.Text);
                Variables.rs = Convert.ToDouble(rsInput.Text);
                Variables.rb = Convert.ToDouble(rbInput.Text);
                Variables.rbt = Convert.ToDouble(rbtInput.Text);
                Variables.y = Convert.ToDouble(yInput.Text);
                Variables.y1 = Convert.ToDouble(y1Input.Text);
                IntermediateValuesOfFormulas.epselentB = Convert.ToDouble(epselentBInput.Text);
                IntermediateValuesOfFormulas.epselentL = Convert.ToDouble(epselentLInput.Text);
            }
            catch
            {
                MessageBox.Show("Все ячейки должны быть заполнены. Если число дробное, то оно пишется через ,");
                Application.Restart();
                this.Close();
            }
            
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
