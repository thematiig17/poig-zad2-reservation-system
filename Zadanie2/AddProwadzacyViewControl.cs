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
    public partial class AddProwadzacyViewControl : UserControl, IAddProwadzacyView
    {
        public AddProwadzacyViewControl()
        {
            InitializeComponent();

            dodajProwadzacego_button.Click += (s, e) => AddProwadzacegoClicked?.Invoke(this, EventArgs.Empty);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Imie
        {
            get => imie_textBox.Text;
            set => imie_textBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nazwisko
        {
            get => nazwisko_textBox.Text;
            set => nazwisko_textBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Prowadzacy.StopienNaukowy Stopien
        {
            get => (Prowadzacy.StopienNaukowy)tytulNaukowy_comboBox.SelectedIndex;
            set => tytulNaukowy_comboBox.SelectedIndex = (int)value;
        }

        public event EventHandler AddProwadzacegoClicked;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UstawDostepneStopnie(List<Prowadzacy.StopienNaukowy> typy)
        {
            tytulNaukowy_comboBox.DataSource = typy;
        }
        public void OdswiezListeProwadzacych(List<Prowadzacy> listaProwadzacych)
        {
            listaProwadzacych_listBox.Items.Clear();
            foreach (var prowadzacy in listaProwadzacych)
            {
                listaProwadzacych_listBox.Items.Add(prowadzacy.ToString());
            }
        }
    }
}
