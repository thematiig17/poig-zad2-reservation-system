using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;

namespace Zadanie2.View
{
    public interface IWydzialView
    {
        string NazwaWydzialu { get; set; }
        string Ulica { get; set; }
        string Numer { get; set; }
        string Miasto { get; set; }

        event EventHandler DodajWydzialClicked;

        void ShowMessage(string message);
        void OdswiezListeWydzialow(List<Wydzial> listaWydzialow);
    }
}
