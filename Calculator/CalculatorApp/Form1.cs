using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nilai1, nilai2, hasil;

            if (Operasi1.SelectedIndex == -1)
            {
                MessageBox.Show("Sertakan operator");
            }else if(Operasi1.SelectedIndex == 0)
            
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 + nilai2;
                hasiltext.Text = hasil.ToString();
            }else if(Operasi1.SelectedIndex == 1)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 - nilai2;
                hasiltext.Text = hasil.ToString();
            }else if(Operasi1.SelectedIndex == 2)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 * nilai2;
                hasiltext.Text = hasil.ToString();
            }else if(Operasi1.SelectedIndex == 3)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 / nilai2;
                hasiltext.Text = hasil.ToString();
            }
        }

        private void hasiltext_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
