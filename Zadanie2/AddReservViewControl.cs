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
    public partial class AddReservViewControl : UserControl, IAddReservView
    {
        public AddReservViewControl()
        {
            InitializeComponent();

            dodajRezerwacje_button.Click += (s, e) => AddRezerwacjeClicked?.Invoke(this, EventArgs.Empty);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime PoczatekRezerwacji
        {
            get => poczatek_dateTime.Value;
            set => poczatek_dateTime.Value = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime KoniecRezerwacji
        {
            get => koniec_dateTime.Value;
            set => koniec_dateTime.Value = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Sala WybranaSala
        {
            get => wybranaSala_comboBox.SelectedItem as Sala;
            set => wybranaSala_comboBox.SelectedItem = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Prowadzacy WybranyProwadzacy
        {
            get => wybranyProwadzacy_comboBox.SelectedItem as Prowadzacy;
            set => wybranyProwadzacy_comboBox.SelectedItem = value;
        }
        public event EventHandler AddRezerwacjeClicked;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void WczytajProwadzacychDoWyboru(List<Prowadzacy> prowadzacy)
        {
            wybranyProwadzacy_comboBox.DataSource = null;
            wybranyProwadzacy_comboBox.DataSource = prowadzacy;
        }
        public void WczytajSaleDoWyboru(List<Sala> sala)
        {
            wybranaSala_comboBox.DataSource = null;
            wybranaSala_comboBox.DataSource = sala;
        }
    }
}
