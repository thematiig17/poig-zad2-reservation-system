using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class AllReservPresenter
    {
        private readonly IAllReservView _view;
        private readonly ReservRepository _reservRepo;

        public AllReservPresenter(IAllReservView view, ReservRepository reservRepo)
        {
            _view = view;
            _reservRepo = reservRepo;

            OdswiezListe();
        }

        public void OdswiezListe()
        {
            var rezerwacje = _reservRepo.GetAll();
            _view.UstawListeRezerwacji(rezerwacje);
        }
    }
}
