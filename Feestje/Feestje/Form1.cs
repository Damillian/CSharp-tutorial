using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feestje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total;

            //30 euro standaard decoratie
            double vasteKosten = 30.00;
            if (cbFancy.Checked)
                vasteKosten += 20.00;

            //5 euro pp fris, 25 euro pp voedsel, 7.50 pp standaard decoratie
            double kostenPerPersoon = 37.50;
            if (cbAlcohol.Checked)
                kostenPerPersoon += 15;
            if (cbFancy.Checked)
                kostenPerPersoon += 7.50;

            total = vasteKosten + double.Parse(nudPeople.Value.ToString()) * kostenPerPersoon;

            if (!cbAlcohol.Checked)
                total *= 0.95;

            tbTotal.Text = total.ToString();
        }
    }
}
