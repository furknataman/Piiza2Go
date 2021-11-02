using Piiza2Go.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Piiza2Go
{
    public partial class Form1 : Form
    {
        Pizza pizza;
        List<Pizza> siparişTablosu = new List<Pizza>();
        List<Pizza> tezgah = new List<Pizza>();


        public Form1()
        {

            //commit

            InitializeComponent();

            pizza = new Pizza();

            lstBoxMalzemeler.Items.Add("Mozeralla");

            UpdatePrice();
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
                pizza.Malzemeler.Remove(silinecekMalzeme);
            }

            UpdatePrice();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int yeni = trcSosSeviyesi.Value;
            pizza.Sos = yeni;

            UpdatePrice();
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
            Pizza eklenecekPizza = Helper.CreateDeepCopy(pizza);
            eklenecekPizza.SiparisTarihi = DateTime.Now;
            
            siparişTablosu.Add(eklenecekPizza);

            lstBoxSiparis.Items.Add(eklenecekPizza.ReadableName);

            CleanOrder();

            UpdatePrice();

            lstBoxMalzemeler.Items.Add("Mozeralla");
        }

        private void CleanOrder()
        {
            chkMantar.Checked = false;
            chkMisir.Checked = false;
            chkPastirma.Checked = false;
            chkSucuk.Checked = false;
            chkTursu.Checked = false;

            trcSosSeviyesi.Value = 1;
            cmbBoyut.SelectedIndex = 0;

            radioKalin.Checked = false;
            radioOrta.Checked = false;
            radioInce.Checked = false;

            lstBoxMalzemeler.Items.Clear();
        }

        private void UpdatePrice()
        {
            lblToplam.Text = pizza.ToplamFiyat.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pizza placeholderPizza = new Pizza();
            
            foreach (Pizza item in siparişTablosu)
            {
                if (item.SiparisTarihi.AddSeconds(5) < DateTime.Now && !tezgah.Contains(item))
                {
                    placeholderPizza = item;
                    tezgah.Add(placeholderPizza);
                }
            }

            siparişTablosu.Remove(placeholderPizza);
            
            UpdateOrderTable();
            UpdateTezgahTable();
        }

        private void lstBoxSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateOrderTable()
        {
            lstBoxSiparis.Items.Clear();
            foreach (Pizza order in siparişTablosu)
            {
                lstBoxSiparis.Items.Add(order.ReadableName);
            }
        }
        private void UpdateTezgahTable()
        {
            lstBoxTezgah.Items.Clear();
            foreach (Pizza order in tezgah)
            {
                lstBoxTezgah.Items.Add(order.ReadableName);
            }
        }
    }
}


