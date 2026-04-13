using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2
{
    public partial class WydzialViewControl : UserControl, IWydzialView
    {
        public WydzialViewControl()
        {
            InitializeComponent();

            dodajWydzial_button.Click += (s, e) => DodajWydzialClicked?.Invoke(this, EventArgs.Empty);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NazwaWydzialu { get => nazwaWydzialu_textBox.Text; set => nazwaWydzialu_textBox.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Ulica { get => ulica_textBox.Text; set => ulica_textBox.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Numer { get => nrBudynku_textBox.Text; set => nrBudynku_textBox.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Miasto { get => miasto_textBox.Text; set => miasto_textBox.Text = value; }


        public event EventHandler DodajWydzialClicked;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void OdswiezListeWydzialow(List<Wydzial> listaWydzialow)
        {
            listaWydzialow_listBox.Items.Clear();
            foreach (var wydzial in listaWydzialow)
            {
                // Możesz nadpisać metodę ToString() w klasie Wydzial, 
                // żeby tu ładnie wyglądało, np: "Wydzial AEI (ul. Akademicka 16, Gliwice)"
                listaWydzialow_listBox.Items.Add($"{wydzial.Nazwa} - {wydzial.AdresWydzialu.Miejscowosc}, {wydzial.AdresWydzialu.Ulica} {wydzial.AdresWydzialu.Nr}");
            }
        }

        private void WydzialViewControl_Load(object sender, EventArgs e)
        {

        }
    }
}
