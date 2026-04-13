using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class AddRoomPresenter
    {
        private readonly IAddRoomView _view;
        private readonly SalaRepository _salaRepo;
        private readonly WydzialRepository _wydzialRepo;

        public AddRoomPresenter(IAddRoomView view, SalaRepository salaRepo, WydzialRepository wydzialRepo)
        {
            _view = view;
            _salaRepo = salaRepo;
            _wydzialRepo = wydzialRepo;

            var dostepneTypy = Enum.GetValues(typeof(Sala.RodzajSali))
                                   .Cast<Sala.RodzajSali>()
                                   .ToList();
            _view.UstawDostepneTypySal(dostepneTypy);

            _view.AddRoomClicked += OnAddRoomClicked;

            OdswiezListeWydzialow();
        }
        public void OdswiezListeWydzialow()
        {
            var wydzialy = _wydzialRepo.GetAll();
            _view.WczytajWydzialyDoWyboru(wydzialy);
        }
        private void OnAddRoomClicked(object sender, EventArgs e)
        {
            if (_view.Wydzial == null)
            {
                _view.ShowMessage("Musisz wybrać wydział dla tej sali!");
                return;
            }

            Sala nowaSala = new Sala
            {
                NumerSali = _view.NumerSali,
                InnaNazwa = _view.InnaNazwa,
                Pojemnosc = _view.Pojemnosc,
                TypSali = _view.TypSali,
                Wydzial = _view.Wydzial
            };

            _salaRepo.Add(nowaSala);

            _view.ShowMessage("Sala została pomyślnie dodana!");

            _view.NumerSali = "";
            _view.InnaNazwa = "";
        }
    }

}
