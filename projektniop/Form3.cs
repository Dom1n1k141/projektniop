using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projektniop
{
    public partial class Form1 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                double masa1 = Convert.ToDouble(textBox1.Text);
                double brzina1 = Convert.ToDouble(textBox2.Text);
                double masa2 = Convert.ToDouble(textBox3.Text);
                double brzina2 = Convert.ToDouble(textBox4.Text);

               
                double p1 = masa1 * brzina1;
                double p2 = masa2 * brzina2;

                
                double ukupnoGibanje = p1 + p2;

               
                MessageBox.Show($"Količina gibanja:\n" +
                                $"Objekt 1: {p1} kg·m/s\n" +
                                $"Objekt 2: {p2} kg·m/s\n" +
                                $"Ukupno: {ukupnoGibanje} kg·m/s",
                                "Rezultati");
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo unesite valjane brojeve u sva polja.", "Greška");
            }
        }
    }
}
