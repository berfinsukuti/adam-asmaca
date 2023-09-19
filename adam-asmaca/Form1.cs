using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kelime;
        Random rnd = new Random();
        int bilememe = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            int sayi = rnd.Next(1, 10);

            if (sayi == 1) kelime = "araba";
            if (sayi == 2) kelime = "karpuz";
            if (sayi == 3) kelime = "bilgisayar";
            if (sayi == 4) kelime = "uçak";
            if (sayi == 5) kelime = "telefon";
            if (sayi == 6) kelime = "mobilya";
            if (sayi == 7) kelime = "baklava";
            if (sayi == 8) kelime = "oyuncak";
            if (sayi == 9) kelime = "kalem";

            string st = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                st = st + "*";
            }

            lblKelime.Text = st;




        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {

            if ((kelime == lblKelime.Text) && (bilememe < 6)) MessageBox.Show("Kazandın");
            if (bilememe >= 6) MessageBox.Show("Öldünüz");



            bool bildi = false;
            string durum = lblKelime.Text;

            string st2 = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime.Substring(i, 1) == txtHarf.Text)
                {
                    bildi = true;
                    st2 = st2 + kelime.Substring(i, 1);
                    continue;

                }

                if (durum.Substring(i, 1) == "*") st2 = st2 + "*";
                else st2 = st2 + durum.Substring(i, 1);

            }

            lblKelime.Text = st2;


            if (bildi==false) bilememe++;

            if (bilememe == 1) pcB1.Visible = true;
            if (bilememe == 2) pcB2.Visible = true;
            if (bilememe == 3) pcB3.Visible = true;
            if (bilememe == 4) pcB4.Visible = true;
            if (bilememe == 5) pcB5.Visible = true;
            if (bilememe == 6) pcB6.Visible = true;



        }
    }
}
