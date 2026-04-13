using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class AddProwadzacyPresenter
    {
        private readonly IAddProwadzacyView _view;
        private readonly ProwadzacyRepository _repository;

        public AddProwadzacyPresenter(IAddProwadzacyView view, ProwadzacyRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.AddProwadzacegoClicked += OnDodajProwadzacegoClicked;

            var dostepneTypy = Enum.GetValues(typeof(Prowadzacy.StopienNaukowy))
                                   .Cast<Prowadzacy.StopienNaukowy>()
                                   .ToList();
            _view.UstawDostepneStopnie(dostepneTypy);

            UpdateListView();
        }

        private void OnDodajProwadzacegoClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.Imie) || string.IsNullOrWhiteSpace(_view.Nazwisko))
            {
                _view.ShowMessage("Podaj Imie i Nazwisko!");
                return;
            }

            Prowadzacy nowyProwadzacy = new Prowadzacy
            {
                Imie = _view.Imie,
                Nazwisko = _view.Nazwisko,
                Stopien = _view.Stopien
            };

            _repository.Add(nowyProwadzacy);

            _view.Imie = "";
            _view.Nazwisko = "";

            UpdateListView();

            _view.ShowMessage("Prowadzacy dodany!");
        }
        public void UpdateListView()
        {
            _view.OdswiezListeProwadzacych(_repository.GetAll());
        }
    }
}
