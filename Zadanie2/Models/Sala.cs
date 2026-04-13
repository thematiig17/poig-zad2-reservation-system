using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class Sala
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NumerSali { get; set; }
        public string InnaNazwa { get; set; }
        public int Pojemnosc { get; set; }
        public Wydzial Wydzial { get; set; }
        public RodzajSali TypSali { get; set; }
        public Adres Adres { get; set; }
        public enum RodzajSali
        {
            Laboratorium,
            Wykładowa,
            Ćwiczeniowa
        }
        public override string ToString()
        {
            return $"Sala: {NumerSali} ({InnaNazwa}) - {TypSali}, Pojemność: {Pojemnosc}, Wydział: {Wydzial}";
        }
    }
}
