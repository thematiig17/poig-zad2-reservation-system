using System.ComponentModel;
using Zadanie2.Models;
using Zadanie2.Presenters;
using Zadanie2.View;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        private readonly WydzialPresenter _wydzialPresenter;
        private readonly AddRoomPresenter _addRoomPresenter;
        private readonly AllRoomPresenter _allRoomPresenter;
        private readonly AddProwadzacyPresenter _addProwadzacyPresenter;
        private readonly AddReservPresenter _addReservPresenter;
        private readonly SaveLoadButtonsPresenter _saveLoadButtonsPresenter;
        public Form1(WydzialRepository wydzialRepository, SalaRepository salaRepository, ProwadzacyRepository prowadzacyRepository, ReservRepository reservRepository)
        {
            InitializeComponent();

            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                if (tabControl1.SelectedTab == dodajSale_tabPage)
                {
                    _addRoomPresenter.OdswiezListeWydzialow();
                }
                else if (tabControl1.SelectedTab == wszystkieSale_tabPage)
                {
                    _allRoomPresenter.OdswiezListe();
                }
                else if (tabControl1.SelectedTab == rezerwacjaSali_tabPage)
                {
                    _addReservPresenter.OdswiezListeProwadzacych();
                    _addReservPresenter.OdswiezListeSal();
                }
                else if (tabControl1.SelectedTab == dodajProwadzacego_tabPage)
                {
                    _addProwadzacyPresenter.UpdateListView();
                }
                else if (tabControl1.SelectedTab == wydzialy_tabPage)
                {
                    _wydzialPresenter.UpdateListView();
                }

            };


            _wydzialPresenter = new WydzialPresenter(wydzialViewControl1, wydzialRepository);
            _addRoomPresenter = new AddRoomPresenter(addRoomViewControl1, salaRepository, wydzialRepository);
            _allRoomPresenter = new AllRoomPresenter(allRoomViewControl1, salaRepository);
            _addProwadzacyPresenter = new AddProwadzacyPresenter(addProwadzacyViewControl1, prowadzacyRepository);
            _addReservPresenter = new AddReservPresenter(addReservViewControl1, salaRepository, prowadzacyRepository, reservRepository);
            _saveLoadButtonsPresenter = new SaveLoadButtonsPresenter(saveLoadButtons1, salaRepository, wydzialRepository, prowadzacyRepository, reservRepository);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
