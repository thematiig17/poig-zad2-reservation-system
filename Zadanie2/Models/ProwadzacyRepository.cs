using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class ProwadzacyRepository
    {
        private readonly List<Prowadzacy> _prowadzacy = new List<Prowadzacy>();

        public void Add(Prowadzacy prowadzacy)
        {
            _prowadzacy.Add(prowadzacy);
        }

        public List<Prowadzacy> GetAll()
        {
            return new List<Prowadzacy>(_prowadzacy);
        }
        public void Clear()
        {
            _prowadzacy.Clear();
        }
    }
}
