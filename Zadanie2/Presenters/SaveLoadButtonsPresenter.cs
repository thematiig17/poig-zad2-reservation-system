using System;
using System.Collections.Generic;
using System.Text;
using Zadanie2.Models;
using Zadanie2.View;

namespace Zadanie2.Presenters
{
    public class SaveLoadButtonsPresenter
    {
        private readonly IFileServiceView _view;
        private readonly SalaRepository _salaRepo;
        private readonly WydzialRepository _wydzialRepo;
        private readonly ProwadzacyRepository _prowadzacyRepo;
        private readonly ReservRepository _rezerwacjaRepo;

        public SaveLoadButtonsPresenter(IFileServiceView view, SalaRepository salaRepo, WydzialRepository wydzialRepo, ProwadzacyRepository prowadzacyRepo, ReservRepository reservRepo)
        {
            _view = view;
            _salaRepo = salaRepo;
            _wydzialRepo = wydzialRepo;
            _prowadzacyRepo = prowadzacyRepo;
            _rezerwacjaRepo = reservRepo;
            _view.SaveToFileClicked += OnSaveButtonClicked;
            _view.LoadFromFileClicked += OnLoadButtonClicked;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Zapisz wszystkie dane";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Database bazaDoZapisu = new Database
                {
                    Wydzialy = _wydzialRepo.GetAll(),
                    Sale = _salaRepo.GetAll(),
                    Prowadzacy = _prowadzacyRepo.GetAll(),
                    Rezerwacje = _rezerwacjaRepo.GetAll()
                };
                FileService.ZapiszDane(bazaDoZapisu, saveFileDialog.FileName);
                MessageBox.Show("Lista studentów została zapisana do pliku JSON.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OnLoadButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wczytaj wszystkie dane";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Database wczytanaBaza = FileService.WczytajDane(openFileDialog.FileName);
                if (wczytanaBaza != null)
                {
                    _wydzialRepo.Clear();
                    _salaRepo.Clear();
                    _prowadzacyRepo.Clear();
                    _rezerwacjaRepo.Clear();
                    foreach (var wydzial in wczytanaBaza.Wydzialy)
                        _wydzialRepo.Add(wydzial);
                    foreach (var sala in wczytanaBaza.Sale)
                        _salaRepo.Add(sala);
                    foreach (var prowadzacy in wczytanaBaza.Prowadzacy)
                        _prowadzacyRepo.Add(prowadzacy);
                    foreach (var rezerwacja in wczytanaBaza.Rezerwacje)
                        _rezerwacjaRepo.Add(rezerwacja);
                    MessageBox.Show("Dane zostały pomyślnie wczytane z pliku JSON.", "Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nie udało się wczytać danych z pliku JSON.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
