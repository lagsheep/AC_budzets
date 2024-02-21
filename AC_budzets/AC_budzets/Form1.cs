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


        public void gridas_izmaksas(int alga, int papildus, int partika, int ire, int komunalie)
        {

            alga = Convert.ToInt32(numericUpDown1.Value);

            papildus = Convert.ToInt32(numericUpDown2.Value);

            ire = Convert.ToInt32(numericUpDown3.Value);

            partika = Convert.ToInt32(numericUpDown4.Value);

            int ienakumi = alga + papildus;

            int izmaksa = ire + partika + komunalie;

            int budzets = ienakumi - izmaksa;
            textBox1.Text = izmaksa.ToString();


        }






    }
}
