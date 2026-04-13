using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using static Zadanie2.Models.Sala;

namespace Zadanie2.View
{
    public interface IAddRoomView
    {
        string NumerSali { get; set; }
        string InnaNazwa { get; set; }
        int Pojemnosc { get; set; }
        Wydzial Wydzial { get; set; }
        RodzajSali TypSali { get; set; }

        event EventHandler AddRoomClicked;

        void ShowMessage(string message);
        void WczytajWydzialyDoWyboru(List<Wydzial> wydzialy);
        void UstawDostepneTypySal(List<Sala.RodzajSali> typy);
        
    }
}
