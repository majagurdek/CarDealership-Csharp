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
    public partial class Zarezerwuj : Form
    {
        List<Samochod> polubione;
        public Zarezerwuj()
        {
            InitializeComponent();
            Initialize();

        }

        public void Initialize()
        {
            comboBox1.Items.Clear();
            polubione = BazaDanych.samochody.Where(
                s => BazaDanych.ulubioneId.Contains(s.id)).ToList();
            polubione.ForEach(s => comboBox1.Items.Add(s.marka+" "+s.model+" "+s.kolor+" "+s.silnik));
        }

        private void Rezerwuj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            if (nazwiskoTXB.Text == "") return;
            Reservation nowarez = new Reservation();
            nowarez.carId = polubione[comboBox1.SelectedIndex].id;
            nowarez.nazwisko = nazwiskoTXB.Text;
            nowarez.day = dateTimePicker1.Value.ToString();
            BazaDanych.reservations.Add(nowarez);
            textBox1.Text += nowarez.nazwisko + "\t" + nowarez.day + "\t" + comboBox1.SelectedItem.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
