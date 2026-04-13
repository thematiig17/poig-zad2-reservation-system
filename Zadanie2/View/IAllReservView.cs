using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;

namespace Zadanie2.View
{
    public interface IAllReservView
    {
        void UstawListeRezerwacji(List<Reserv> rezerwacje);
    }
}
