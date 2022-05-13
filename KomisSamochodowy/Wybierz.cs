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
    public partial class Wybierz : Form
    {
        public List<Samochod> dopasowane;
        public Wybierz()
        {
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
           dopasowane = BazaDanych.samochody;
            UpdateDropdowns();
        }

        public void UpdateDropdowns()
        {
            MarkaCBX.Items.Clear();
            dopasowane.Select(d => d.marka).Distinct()
                .ToList().ForEach(s=>MarkaCBX.Items.Add(s));
            if (MarkaCBX.Items.Count == 1)
                MarkaCBX.SelectedIndex = 0;

            ModelCBX.Items.Clear();
            dopasowane.Select(d => d.model).Distinct()
                .ToList().ForEach(s => ModelCBX.Items.Add(s));
            if (ModelCBX.Items.Count == 1)
                ModelCBX.SelectedIndex = 0;

            KolorCBX.Items.Clear();
            dopasowane.Select(d => d.kolor).Distinct()
                .ToList().ForEach(s => KolorCBX.Items.Add(s));
            if (KolorCBX.Items.Count == 1)
                KolorCBX.SelectedIndex = 0;

            SilnikCBX.Items.Clear();
            dopasowane.Select(d => d.silnik).Distinct()
                .ToList().ForEach(s => SilnikCBX.Items.Add(s));
            if (SilnikCBX.Items.Count == 1)
                SilnikCBX.SelectedIndex = 0;
        }

        public void FindMatch()
        {
            dopasowane = BazaDanych.samochody;

            if (MarkaCBX.SelectedIndex != -1)
            {
                string marka = MarkaCBX.Items[MarkaCBX.SelectedIndex].ToString();
                dopasowane = dopasowane.Where(s => s.marka == marka).ToList();
            }
            if (ModelCBX.SelectedIndex != -1)
            {
                string model = ModelCBX.Items[ModelCBX.SelectedIndex].ToString();
                dopasowane = dopasowane.Where(s => s.model == model).ToList();
            }
            if (KolorCBX.SelectedIndex != -1)
            {
                string kolor = KolorCBX.Items[KolorCBX.SelectedIndex].ToString();
                dopasowane = dopasowane.Where(s => s.kolor == kolor).ToList();
            }
            if (SilnikCBX.SelectedIndex != -1)
            {
                string silnik = SilnikCBX.Items[SilnikCBX.SelectedIndex].ToString();
                dopasowane = dopasowane.Where(s => s.silnik == silnik).ToList();
            }
        }

        private void AddToFav_Click(object sender, EventArgs e)
        {
            if (dopasowane.Count != 1) return;
            Samochod wybraniec = dopasowane[0];
            if (BazaDanych.ulubioneId.Contains(wybraniec.id)) return;
            BazaDanych.ulubioneId.Add(wybraniec.id);
        }

        bool surpres = false;
        private void AnyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (surpres) return;

            surpres = true;
            FindMatch();
            UpdateDropdowns();
            surpres = false;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
