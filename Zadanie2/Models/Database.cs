using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class Database
    {
        public List<Wydzial> Wydzialy { get; set; } = new List<Wydzial>();
        public List<Sala> Sale { get; set; } = new List<Sala>(); 
        public List<Prowadzacy> Prowadzacy { get; set; } = new List<Prowadzacy>();
        public List<Reserv> Rezerwacje { get; set; }  = new List<Reserv>();
    }
}
