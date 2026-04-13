using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.Models
{
    public class ReservRepository
    {
        private readonly List<Reserv> _rezerwacje = new List<Reserv>();

        public void Add(Reserv reserv)
        {
            _rezerwacje.Add(reserv);
        }

        public List<Reserv> GetAll()
        {
            return new List<Reserv>(_rezerwacje);
        }
        public void Clear()
        {
            _rezerwacje.Clear();
        }

        public bool CzySalaZajeta(Guid idSali, DateTime nowyPoczatek, DateTime nowyKoniec)
        {
            return _rezerwacje.Any(r =>
                r.Sala.Id == idSali &&
                r.poczatekRezerwacji < nowyKoniec &&
                r.koniecRezerwacji > nowyPoczatek
            );
        }
    }
}
