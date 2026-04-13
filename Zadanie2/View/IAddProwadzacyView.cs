using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;

namespace Zadanie2.View
{
    public interface IAddProwadzacyView
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        Prowadzacy.StopienNaukowy Stopien { get; set; }

        event EventHandler AddProwadzacegoClicked;

        void ShowMessage(string message);
        void OdswiezListeProwadzacych(List<Prowadzacy> listaProwadzacych);
        void UstawDostepneStopnie(List<Prowadzacy.StopienNaukowy> typy);
    }
}
