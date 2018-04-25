using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampiyonlarLigi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> grular = new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;
            takimlar = new List<Takim>();

            yenitakim = new Takim("Bayen Münüh", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Dortmut", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Lil", "Frnasa");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Galatasaray", "Turkey");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Fenerbahçe", "Turkey");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Beşiktaş", "Turkey");
            takimlar.Add(yenitakim);


            yenitakim = new Takim("TrabzonSpor", "Turkey");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("BursaSpor", "Turkey");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("OsmanlıSpor", "Turkey");
            takimlar.Add(yenitakim);


            yenitakim = new Takim("Barcelone", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("ReelMadrid", "ispanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("AtlicoMadrid", "İspanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Kastamonupor", "Turkey");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("BayenMünüh", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("İnter", "İngiltere");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Cheelsi", "Fransa");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Bayen Münüh", "Almanya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Dortmut", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Lil", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Galatasaray", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Fenerbahçe", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Beşiktaş", "Know");
            takimlar.Add(yenitakim);


            yenitakim = new Takim("TrabzonSpor", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("BursaSpor", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("OsmanlıSpor", "Know");
            takimlar.Add(yenitakim);


            yenitakim = new Takim("Barcelone", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("ReelMadrid", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("AtlicoMadrid", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Kastamonupor", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("BayenMünüh", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("İnter", "Know");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Cheelsi"," Know");
            takimlar.Add(yenitakim);

             













        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> Secilentakimlar = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                Secilentakimlar.Clear();
                for (int j = 0; j < 8; j++)
                {
                    int secilen = rnd.Next(0, takimlar.Count / 4);
                    if (Secilentakimlar.Contains(secilen))
                    {
                        j--;
                    }
                    else
                    {
                        Secilentakimlar.Add(secilen);
                    }
                }
                bool aynıulkedenTakimlar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedenTakimlar = Ayniulkedentakimlar(grular[k], torbalar[i].Items[Secilentakimlar[k]] as Takim);
                    if (aynıulkedenTakimlar)
                    {
                        break;
                    }
                }
                if (!aynıulkedenTakimlar)
                {
                    listBox1.Items.Add(torbalar[i].Items[Secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[i].Items[Secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[i].Items[Secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[i].Items[Secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[i].Items[Secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[i].Items[Secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[i].Items[Secilentakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[i].Items[Secilentakimlar[7]] as Takim);
                }
                else
                {
                   i++;
                }
            }
        }
        private bool Ayniulkedentakimlar(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                int secşlentakim = rast.Next(0, takimlar.Count);
                if (secilentakimlar.Contains(secşlentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secşlentakim);
                }
            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    lstTorba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    lstTorba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if(i<24)
                {
                    lstTorba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    lstTorba4.Items.Add(takimlar[secilentakimlar[i]]);
                }

            }
            torbalar.Add(lstTorba1);
            torbalar.Add(lstTorba2);
            torbalar.Add(lstTorba3);
            torbalar.Add(lstTorba4);

            grular.Add(listBox1);
            grular.Add(listBox2);
            grular.Add(listBox3);
            grular.Add(listBox4);
            grular.Add(listBox5);
            grular.Add(listBox6);
            grular.Add(listBox7);
            grular.Add(listBox8);
           
        }
    }
}
