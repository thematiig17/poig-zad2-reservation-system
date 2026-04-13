using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class AddReservPresenter
    {
        private readonly IAddReservView _view;
        private readonly SalaRepository _salaRepository;
        private readonly ProwadzacyRepository _prowadzacyRepository;
        private readonly ReservRepository _reservRepository = new ReservRepository();

        public AddReservPresenter(IAddReservView view, SalaRepository salaRepository, ProwadzacyRepository prowadzacyRepository, ReservRepository reservRepository)
        {
            _view = view;
            _salaRepository = salaRepository;
            _prowadzacyRepository = prowadzacyRepository;
            _reservRepository = reservRepository;

            _view.AddRezerwacjeClicked += OnAddRezerwacjeClicked;

            OdswiezListeProwadzacych();
            OdswiezListeSal();
            
        }
        public void OdswiezListeProwadzacych()
        {
            var prowadzacyList = _prowadzacyRepository.GetAll();
            _view.WczytajProwadzacychDoWyboru(prowadzacyList);
        }
        public void OdswiezListeSal()
        {
            var salaList = _salaRepository.GetAll();
            _view.WczytajSaleDoWyboru(salaList);
        }
        private void OnAddRezerwacjeClicked(object sender, EventArgs e)
        {
            var poczatek = _view.PoczatekRezerwacji;
            var koniec = _view.KoniecRezerwacji;
            var sala = _view.WybranaSala;
            var prowadzacy = _view.WybranyProwadzacy;
            if (poczatek >= koniec)
            {
                _view.ShowMessage("Data zakończenia musi być późniejsza niż data rozpoczęcia.");
                return;
            }
            if (sala == null)
            {
                _view.ShowMessage("Proszę wybrać salę.");
                return;
            }
            if (prowadzacy == null)
            {
                _view.ShowMessage("Proszę wybrać prowadzącego.");
                return;
            }

            Reserv rezerwacja = new Reserv
            {
                poczatekRezerwacji = poczatek,
                koniecRezerwacji = koniec,
                Sala = sala,
                Prowadzacy = prowadzacy
            };

            _reservRepository.Add(rezerwacja);

            _view.ShowMessage("Rezerwacja została dodana pomyślnie.");
        }
    }
}
