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
    public partial class AddRoomViewControl : UserControl, IAddRoomView
    {
        public AddRoomViewControl()
        {
            InitializeComponent();

            dodajSale_button.Click += (s, e) => AddRoomClicked?.Invoke(this, EventArgs.Empty);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumerSali
        {
            get => numerSali_textBox.Text;
            set => numerSali_textBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string InnaNazwa
        {
            get => innaNazwa_textBox.Text;
            set => innaNazwa_textBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Pojemnosc
        {
            get => int.TryParse(pojemnosc_textBox.Text, out var val) ? val : 0;
            set => pojemnosc_textBox.Text = value.ToString();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Wydzial Wydzial
        {
            get => wydzial_comboBox.SelectedItem as Wydzial;
            set => wydzial_comboBox.SelectedItem = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Sala.RodzajSali TypSali
        {
            get => (Sala.RodzajSali)typSali_comboBox.SelectedIndex;
            set => typSali_comboBox.SelectedIndex = (int)value;
        }

        public event EventHandler AddRoomClicked;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void WczytajWydzialyDoWyboru(List<Wydzial> wydzialy)
        {
            wydzial_comboBox.DataSource = null;
            wydzial_comboBox.DataSource = wydzialy;
        }
        public void UstawDostepneTypySal(List<Sala.RodzajSali> typy)
        {
            typSali_comboBox.DataSource = typy;
        }

        private void AddRoomViewControl_Load(object sender, EventArgs e)
        {

        }
    }
}
