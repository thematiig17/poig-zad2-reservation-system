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
    public partial class AllReservViewControl : UserControl, IAllReservView
    {
        public AllReservViewControl()
        {
            InitializeComponent();
        }
        public void UstawListeRezerwacji(List<Reserv> rezerwacje)
        {
            listaRezerwacji_listBox.Items.Clear();
            foreach (var reserv in rezerwacje)
            {
                listaRezerwacji_listBox.Items.Add(reserv);
            }
        }
    }
}
