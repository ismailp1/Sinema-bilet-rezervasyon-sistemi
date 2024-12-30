using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemeaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        

        private void btn_biletal_Click(object sender, EventArgs e)
        {
            lst_adsoyad.Items.Add(txt_adsoyad.Text);//txt_adsoyad'ı ıtemsını lst_ad soyad ıtemsına ekliyoruz
            lst_telefon.Items.Add(txt_telefon.Text);//Aynı işlemi yapıyoruz
            lst_film.Items.Add(cmb_film.Text);//Combobaxtan girdiğimiz değeri listboxta tutuyoruz
            lst_seans.Items.Add(cmb_seans.Text);
            lst_salon.Items.Add(cmb_salon.Text);
            lst_bilettürü.Items.Add(cmb_bilettürü.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button1.Text);
            button1.BackColor = Color.Red; //koltuk 1'e basıldığı zaman dolu görünmesi için rengini kırmızıya çeviriuorum.
            button1.Enabled = false; // buton bire 1den fazla tıklama özelliğini kapatıyoruz

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button2.Text);
            button2.BackColor = Color.Red; 
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button3.Text);
            button3.BackColor = Color.Red; 
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button4.Text);
            button4.BackColor = Color.Red; 
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button5.Text);
            button5.BackColor = Color.Red; 
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button6.Text);
            button6.BackColor = Color.Red; 
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button7.Text);
            button7.BackColor = Color.Red; 
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button8.Text);
            button8.BackColor = Color.Red; 
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button9.Text);
            button9.BackColor = Color.Red; 
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button10.Text);
            button10.BackColor = Color.Red; 
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button11.Text);
            button11.BackColor = Color.Red; 
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button12.Text);
            button12.BackColor = Color.Red; 
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button13.Text);
            button13.BackColor = Color.Red; 
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button14.Text);
            button14.BackColor = Color.Red; 
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button15.Text);
            button15.BackColor = Color.Red; 
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button16.Text);
            button16.BackColor = Color.Red; 
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button17.Text);
            button17.BackColor = Color.Red; 
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button18.Text);
            button18.BackColor = Color.Red; 
            button18.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button19.Text);
            button19.BackColor = Color.Red; 
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button20.Text);
            button20.BackColor = Color.Red; 
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button21.Text);
            button21.BackColor = Color.Red; 
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button22.Text);
            button22.BackColor = Color.Red; 
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button23.Text);
            button23.BackColor = Color.Red; 
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button24.Text);
            button24.BackColor = Color.Red; 
            button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button25.Text);
            button25.BackColor = Color.Red; 
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button26.Text);
            button26.BackColor = Color.Red; 
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button27.Text);
            button27.BackColor = Color.Red; 
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button28.Text);
            button28.BackColor = Color.Red; 
            button28.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button29.Text);
            button29.BackColor = Color.Red; 
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button30.Text);
            button30.BackColor = Color.Red; 
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button31.Text);
            button31.BackColor = Color.Red; 
            button31.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button32.Text);
            button32.BackColor = Color.Red; 
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button33.Text);
            button33.BackColor = Color.Red; 
            button33.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button34.Text);
            button34.BackColor = Color.Red; 
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button35.Text);
            button35.BackColor = Color.Red; 
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button36.Text);
            button36.BackColor = Color.Red; 
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button37.Text);
            button37.BackColor = Color.Red; 
            button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button38.Text);
            button38.BackColor = Color.Red; 
            button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button39.Text);
            button39.BackColor = Color.Red; 
            button39.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button40.Text);
            button40.BackColor = Color.Red; 
            button40.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button41.Text);
            button41.BackColor = Color.Red; 
            button41.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button42.Text);
            button42.BackColor = Color.Red; 
            button42.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button43.Text);
            button43.BackColor = Color.Red; 
            button43.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button44.Text);
            button44.BackColor = Color.Red; 
            button44.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button45.Text);
            button45.BackColor = Color.Red; 
            button45.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button46.Text);
            button46.BackColor = Color.Red; 
            button46.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button47.Text);
            button47.BackColor = Color.Red; 
            button47.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            lst_koltukno.Items.Add(button48.Text);
            button48.BackColor = Color.Red; 
            button48.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
           

            if (lst_adsoyad.SelectedIndex == -1)
            {
                MessageBox.Show("Güncellemek istediğiniz Seçeneği seçiniz.");
            }
            else
            {
                int index = lst_adsoyad.SelectedIndex;
                lst_adsoyad.Items.Remove(lst_adsoyad.SelectedItem);
                lst_adsoyad.Items.Insert(index, txt_adsoyad.Text);
            }
            
        }

        private void button50_Click(object sender, EventArgs e)
        {
            lst_adsoyad.Items.Remove(lst_adsoyad.SelectedItem);
            lst_telefon.Items.Remove(lst_telefon.SelectedItem);
            lst_bilettürü.Items.Remove(lst_bilettürü.SelectedItem);
            lst_film.Items.Remove(lst_film.SelectedItem);
            lst_koltukno.Items.Remove(lst_koltukno.SelectedItem);
            lst_salon.Items.Remove(lst_salon.SelectedItem);
            lst_seans.Items.Remove(lst_seans.SelectedItem);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

