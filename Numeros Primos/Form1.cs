using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int cont = 0;
            for (int i = 1; i <= n; i++) 
                {
                if (n%i==0)
                    {
                        cont++;

                    }
            }
            if (cont==2)
                {
                label1.Text = n  +  "Es primo!";
            }
            else
            {
                label1.Text = n  +   "No es primo!";
            }
        }
    }
}
