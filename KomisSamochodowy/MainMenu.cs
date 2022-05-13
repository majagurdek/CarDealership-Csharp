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
    public partial class MainMenu : Form
    {
        public static MainMenu singleton;
       
        public MainMenu()
        {
            singleton = this;
            InitializeComponent();
            BazaDanych.LoadCars();
            
        }

        private void AddACar_Click(object sender, EventArgs e)
            //dodaj samochód
        {
            Dodawanie f2 = new Dodawanie();
            f2.Show();
          
        }

        private void BookACar_Click(object sender, EventArgs e)
            //zarezerwuj termin
        {
            Zarezerwuj z = new Zarezerwuj();
            z.ShowDialog();
           
        }

        private void PickACar_Click(object sender, EventArgs e)
        {
            Wybierz w = new Wybierz();
            w.ShowDialog();
            
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
