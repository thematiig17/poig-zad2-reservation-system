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
        public Form1(WydzialRepository wydzialRepository, SalaRepository salaRepository)
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
            };


            _wydzialPresenter = new WydzialPresenter(wydzialViewControl1, wydzialRepository);
            _addRoomPresenter = new AddRoomPresenter(addRoomViewControl1, salaRepository, wydzialRepository);
            _allRoomPresenter = new AllRoomPresenter(allRoomViewControl1, salaRepository);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
