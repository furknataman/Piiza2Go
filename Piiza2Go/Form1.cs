using Piiza2Go.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Piiza2Go
{
    public partial class Form1 : Form
    {
        Pizza pizza;
        int toplamFiyat;
        int eski = 0;
        int fark = 0;
        int gunlukkar = 0;
        List<Pizza> siparişTablosu = new List<Pizza>();
        List<Pizza> tezgah = new List<Pizza>();
       

        public Form1()
        {

            //commit

            InitializeComponent();

            pizza = new Pizza();
            pizza.Malzemeler = new List<Malzeme>();

            Malzeme mozelMalzemesi = new Malzeme();
            mozelMalzemesi.Isim = chkMozeralla.Text;
            mozelMalzemesi.Fiyat = Convert.ToInt32(chkMozeralla.Tag);
            lblToplam.Text = Convert.ToString(chkMozeralla.Tag);
            pizza.Malzemeler.Add(mozelMalzemesi);
            toplamFiyat = Convert.ToInt32(chkMozeralla.Tag);
            lstBoxMalzemeler.Items.Add("Mozeralla");

        }
        private void chkMalzeme_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkMalzeme = sender as CheckBox;

            if (chkMalzeme.Checked)
            {
                lstBoxMalzemeler.Items.Add(chkMalzeme.Text);
                Malzeme eklenecekMalzeme = new Malzeme();
                eklenecekMalzeme.Isim = chkMalzeme.Text;
                eklenecekMalzeme.Fiyat = Convert.ToInt32(chkMalzeme.Tag);
                toplamFiyat = toplamFiyat + eklenecekMalzeme.Fiyat;
                lblToplam.Text = Convert.ToString(toplamFiyat);
                pizza.Malzemeler.Add(eklenecekMalzeme);
            }
            else
            {
                lstBoxMalzemeler.Items.Remove(chkMalzeme.Text);
                Malzeme silinecekMalzeme = new Malzeme();
                foreach (var malzeme in pizza.Malzemeler)
                {
                    if (malzeme.Isim == chkMalzeme.Text)
                    {
                        silinecekMalzeme = malzeme;
                        break;
                    }
                }
                toplamFiyat = toplamFiyat - silinecekMalzeme.Fiyat;
                lblToplam.Text = toplamFiyat.ToString();
                pizza.Malzemeler.Remove(silinecekMalzeme);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int yeni = trackBar1.Value;
            pizza.Sos = yeni;

            fark = yeni - eski;
            toplamFiyat = toplamFiyat + fark;
            lblToplam.Text = toplamFiyat.ToString();
            eski = yeni;
        }
        private void hamurradio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioHamur = sender as RadioButton;
            if (radioHamur.Checked)
            {

                pizza.Hamur = (HamurKalinligi)Convert.ToInt32(radioHamur.Tag);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizza.Boyut = (Boyutlar)cmbBoyut.SelectedIndex;
        }

        

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Pizza eklecekPizza = new Pizza();
            eklecekPizza.Boyut = pizza.Boyut;
            eklecekPizza.Hamur = pizza.Hamur;
            eklecekPizza.Malzemeler = pizza.Malzemeler;
            eklecekPizza.SiparisTarihi = DateTime.Now;
            eklecekPizza.Sos = pizza.Sos;

            //eklecekPizza = Helper.CreateDeepCopy(pizza);

            siparişTablosu.Add(eklecekPizza);

            lstBoxSiparis.Items.Add(cmbBoyut.Text+ " " +" "+ eklecekPizza.Hamur+" "+ toplamFiyat.ToString()+"₺");

            //"Küçük İnce Az Soslu - 24₺";

            //foreach (var malzeme in eklecekPizza.Malzemeler)
            //{
            //    lstBoxSiparis.Items.Add(malzeme.Isim);
            //}

            CleanOrder();

            gunlukkar = gunlukkar + toplamFiyat;
            toplamFiyat = 0;
            toplamFiyat = Convert.ToInt32(chkMozeralla.Tag);
            lblToplam.Text = toplamFiyat.ToString();
            lstBoxMalzemeler.Items.Add("Mozeralla");
            
        }

        private void CleanOrder()
        {
            chkMantar.Checked = false;
            chkMisir.Checked = false;
            chkPastirma.Checked = false;
            chkSucuk.Checked = false;
            chkTursu.Checked = false;
            lstBoxMalzemeler.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}


