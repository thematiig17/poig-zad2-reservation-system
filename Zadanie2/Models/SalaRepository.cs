using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class SalaRepository
    {
        private readonly List<Sala> _sale = new List<Sala>();

        public void Add(Sala sala)
        {
            _sale.Add(sala);
        }

        public List<Sala> GetAll()
        {
            return new List<Sala>(_sale);
        }
    }
}
