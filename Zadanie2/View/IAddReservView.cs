using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;

namespace Zadanie2.View
{
    public interface IAddReservView
    {
        DateTime PoczatekRezerwacji { get; set; }
        DateTime KoniecRezerwacji { get; set; }
        Sala WybranaSala { get; set; }
        Prowadzacy WybranyProwadzacy { get; set; }
        event EventHandler AddRezerwacjeClicked;

        void ShowMessage(string message);
        void WczytajSaleDoWyboru(List<Sala> sale);
        void WczytajProwadzacychDoWyboru(List<Prowadzacy> prowadzacy);

    }
}
