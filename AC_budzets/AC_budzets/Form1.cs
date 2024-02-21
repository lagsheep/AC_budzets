using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_budzets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            int alga = Convert.ToInt32(numericUpDown1.Value);

            if (alga < 0)
            {
                alga = alga * -1;

            }

            int papildus = Convert.ToInt32(numericUpDown2.Value);
            if (papildus < 0)
            {
                papildus = papildus * - 1;

            }
            int ire = Convert.ToInt32(numericUpDown3.Value);
            if (ire < 0)
            {
                ire = ire * -1;

            }

            int partika = Convert.ToInt32(numericUpDown4.Value);
            if (partika < 0)
            {
                partika = partika * -1;

            }

            int komunalie = Convert.ToInt32(numericUpDown5.Value);
            if (komunalie < 0)
            {
                komunalie = komunalie * -1;

            }

            int ienakumi = alga + papildus;

            int izmaksa = ire + partika + komunalie;

            int budzets = ienakumi - izmaksa;

            textBox1.Text = budzets.ToString();

        }
    }
}
