using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class Dodawanie : Form
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void zresetuj(object sender, EventArgs e)
            //zresetuj
        {
            Marka_textbox.Clear();
            model_textbox.Clear();
            silnik_textbox.Clear();
            kolor_textbox.Clear();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void zakończ(object sender, EventArgs e)
            //zakończ
        {
            this.Close();
        }


        private void dodaj(object sender, EventArgs e)
            //dodaj samochód
        {
            Samochod CarToAdd = new Samochod();
            CarToAdd.model = model_textbox.Text;
            CarToAdd.marka = Marka_textbox.Text;
            CarToAdd.kolor = kolor_textbox.Text;
            CarToAdd.silnik = silnik_textbox.Text;

            BazaDanych.samochody.Add(CarToAdd);
            BazaDanych.SaveCars();
        }

        private void Dodawanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.singleton.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
