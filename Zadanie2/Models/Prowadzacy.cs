using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class Prowadzacy
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public StopienNaukowy Stopien { get; set; }
        public enum StopienNaukowy
        {
            Brak,
            Licencjat,
            Inzynier,
            Magister,
            MagisterInzynier,
            Doktor,
            DoktorInzynier,
            DoktorHabilitowany,
            Profesor
        }
        public override string ToString()
        {
            switch(Stopien)
            {
                case StopienNaukowy.Licencjat:
                    return Imie + " " + Nazwisko;
                case StopienNaukowy.Inzynier:
                    return "Inż. " + Imie + " " + Nazwisko;
                case StopienNaukowy.Magister:
                    return "Mgr " + Imie + " " + Nazwisko;
                case StopienNaukowy.MagisterInzynier:
                    return "Mgr inż. " + Imie + " " + Nazwisko;
                case StopienNaukowy.Doktor:
                    return "Dr " + Imie + " " + Nazwisko;
                case StopienNaukowy.DoktorInzynier:
                    return "Dr inż. " + Imie + " " + Nazwisko;
                case StopienNaukowy.DoktorHabilitowany:
                    return "Dr hab. " + Imie + " " + Nazwisko;
                case StopienNaukowy.Profesor:
                    return "Prof. " + Imie + " " + Nazwisko;
            }
            return Imie + " " + Nazwisko;
        }
    }
}
