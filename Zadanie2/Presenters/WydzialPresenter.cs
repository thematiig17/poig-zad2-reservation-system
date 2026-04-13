using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class WydzialPresenter
    {
        private readonly IWydzialView _view;
        private readonly WydzialRepository _repository;

        public WydzialPresenter(IWydzialView view, WydzialRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.DodajWydzialClicked += OnDodajWydzialClicked;
            UpdateListView();
        }

        private void OnDodajWydzialClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.NazwaWydzialu))
            {
                _view.ShowMessage("Podaj nazwę wydziału!");
                return;
            }

            Wydzial nowyWydzial = new Wydzial
            {
                Nazwa = _view.NazwaWydzialu,
                AdresWydzialu = new Adres
                {
                    Ulica = _view.Ulica,
                    Nr = _view.Numer,
                    Miejscowosc = _view.Miasto
                }
            };

            _repository.Add(nowyWydzial);

            _view.NazwaWydzialu = "";
            _view.Ulica = "";
            _view.Numer = "";
            _view.Miasto = "";

            UpdateListView();

            _view.ShowMessage("Wydział dodany!");
        }
        private void UpdateListView()
        {
            _view.OdswiezListeWydzialow(_repository.GetAll());
        }
    }
}
