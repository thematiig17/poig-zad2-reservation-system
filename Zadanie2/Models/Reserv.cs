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
            return $"Rezerwacja: {Sala.NumerSali} - od {poczatekRezerwacji} do {koniecRezerwacji}, Prowadzący: {Prowadzacy.Imie} {Prowadzacy.Nazwisko}";
        }
    }
}
