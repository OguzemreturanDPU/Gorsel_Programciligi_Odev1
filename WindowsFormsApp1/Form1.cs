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
        private double vize;
        private double final;
        private double ortalama;
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                {
                        
                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                ortalama = vize * 0.4 + final * 0.6;

                label1.Text = ortalama.ToString();
                if (ortalama >= 50 || final >= 50)
                    label2.Text = "Geçti";
                else
                    label2.Text = "Kaldı";

                        if (ortalama >= 90 && ortalama <= 100)
                            label3.Text = "AA";
                        if (ortalama >= 85 && ortalama <= 89)
                          label3.Text = "BA";
                        if (ortalama >= 80 && ortalama <= 84)
                            label3.Text = "BB";
                      
                        if (ortalama >= 75 && ortalama <= 79)
                            label3.Text = "CB";
                        
                        if (ortalama >= 70 && ortalama <= 74)
                            label3.Text = "CC";
                        
                        if (ortalama >= 65 && ortalama <= 69)
                            label3.Text = "DC";
                        
                        if (ortalama >= 60 && ortalama <= 64)
                            label3.Text = "DD";
                    
                        if (ortalama >= 50 && ortalama <= 59)
                            label3.Text = "FD";
                        
                        if (ortalama >= 0 && ortalama <= 49)
                            label3.Text = "FF";

                        if (ortalama >= 50 && ortalama <= 100)
                            label3.ForeColor = Color.Green;
                        else
                            label3.ForeColor = Color.Red;

                    }
                }
            }



            catch (Exception ex)
            {
                /* if (textBox1.Text != "" && textBox2.Text != "")
                 {
                  MessageBox.Show("Geçerli Değer Girin");
                 }

           

            if (Convert.ToDouble(vize) < 0 || vize > 100)
            {
                MessageBox.Show("1 ile 100 arasında sayı gir");
            }
            if (Convert.ToDouble(final) < 0 || final > 100)
            {
                MessageBox.Show("1 ile 100 arasında sayı gir");
            }
            */
            }
        }
    }
}
