using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worpengenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            resultListBox.Items.Clear();

            Random RandomClass = new Random();

            decimal count = numericUpDown1.Value;
            int TotaalAantalOgen = 0;

            for (int i = 0; i < count; i++)
            {

                int Aantal = RandomClass.Next(0, (Convert.ToInt32(numericUpDownOgen.Value)+ 1));
                TotaalAantalOgen = TotaalAantalOgen + Aantal;
                resultListBox.Items.Add(Aantal);

            }

            var ItemsFromList = resultListBox.Items.Cast<object>().Select(obj => Convert.ToInt32(obj));
  
            label4.Text = "Totaal aantal ogen: " + TotaalAantalOgen;
            label3.Text = "Hoogste worp : " + ItemsFromList.Max();
            label5.Text = "Laagste worp : " + ItemsFromList.Min();
        }
    }
}
