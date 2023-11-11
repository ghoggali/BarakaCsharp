using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabariApplication
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }
        double Resultat = 0, Tmp = 0;
        char op;
        bool TmpTest = false;
        double Calculer(double x , double y, char Signe )
        {
            
            switch (Signe)
            {
                case '+': return x + y; 
                case 'x': return x * y; 
                case '-': return x - y; 
                case '/': return x / y;
                default: return 0;
            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")|| (TmpTest))
            {
                textBox1.Clear();
                TmpTest = false;    
            }


            textBox1.Text = textBox1.Text+(sender as Button).Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Tmp =double.Parse(textBox1.Text);
            op = (sender as Button).Text[0];
            Resultat = Calculer(Resultat, Tmp,op) ;

            textBox1.Text=Resultat.ToString();

            label1.Text = label1.Text + Tmp + op;
            

            TmpTest = true;


        }

        private void button35_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + textBox1.Text ;
            Tmp=double.Parse(textBox1.Text);
            Resultat = Calculer(Resultat, Tmp, op);
            textBox1.Text = Resultat.ToString();
            TmpTest = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Resultat = 0;
            Tmp = 0;
            label1.Text = "";
            TmpTest = false;
        }
    }
}
