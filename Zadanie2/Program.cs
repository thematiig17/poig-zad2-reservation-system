using Zadanie2.Models;
using Zadanie2.Presenters;

namespace Zadanie2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            WydzialRepository wydzialRepository = new WydzialRepository();
            SalaRepository salaRepository = new SalaRepository();
            ProwadzacyRepository prowadzacyRepository = new ProwadzacyRepository();
            ReservRepository reservRepository = new ReservRepository();


            Form1 view = new Form1(wydzialRepository, salaRepository, prowadzacyRepository, reservRepository);

            Application.Run(view);
        }
    }
}