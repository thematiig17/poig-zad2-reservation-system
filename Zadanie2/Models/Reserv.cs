using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class Reserv
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime poczatekRezerwacji { get; set; }
        public DateTime koniecRezerwacji { get; set; }
        public Sala Sala { get; set; }
        public Prowadzacy Prowadzacy { get; set; }

        public override string ToString()
        {
            string start = poczatekRezerwacji.ToString("dd.MM.yyyy HH:mm");
            string koniec = koniecRezerwacji.ToString("dd.MM.yyyy HH:mm");
            return $"Rezerwacja sali {Sala.NumerSali} - od {start} do {koniec}, Prowadzący: {Prowadzacy.Imie} {Prowadzacy.Nazwisko}";
        }
    }
}
