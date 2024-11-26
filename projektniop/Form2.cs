using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projektniop
{
    public partial class Form1 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double masa = Convert.ToDouble(textBox1.Text);
                double visina = Convert.ToDouble(textBox2.Text);
                double gravitacija = Convert.ToDouble(textBox3.Text);

               
                double potencijalnaEnergija = masa * visina * gravitacija;

             
                MessageBox.Show($"Rezultat je: {potencijalnaEnergija} J", "Potencijalna energija");
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo unesite valjane brojeve u sva polja.", "Greška");
            }
        }
    }
}

