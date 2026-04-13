using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class Wydzial
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Adres AdresWydzialu { get; set; }
        public override string ToString()
        {
            return Nazwa;
        }
    }
}
