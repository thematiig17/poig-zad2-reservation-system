using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class WydzialRepository
    {
        private readonly List<Wydzial> _wydzialy = new List<Wydzial>();

        public void Add(Wydzial wydzial)
        {
            _wydzialy.Add(wydzial);
        }

        public List<Wydzial> GetAll()
        {
            return new List<Wydzial>(_wydzialy);
        }
    }
}
