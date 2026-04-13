using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class AllRoomPresenter
    {
        private readonly IAllRoomView _view;
        private readonly SalaRepository _salaRepo;

        public AllRoomPresenter(IAllRoomView view, SalaRepository salaRepo)
        {
            _view = view;
            _salaRepo = salaRepo;

            OdswiezListe();
        }

        public void OdswiezListe()
        {
            var sale = _salaRepo.GetAll();
            _view.UstawListeSal(sale);
        }
    }
}
