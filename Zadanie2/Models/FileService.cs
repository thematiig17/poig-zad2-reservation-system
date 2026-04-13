using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Zadanie2.Models
{
    public static class FileService
    {
        public static void ZapiszDane(Database database, string sciezka)
        {
            var opcje = new JsonSerializerOptions { WriteIndented = true };
            string json = System.Text.Json.JsonSerializer.Serialize(database, opcje);
            System.IO.File.WriteAllText(sciezka, json);
        }

        public static Database WczytajDane(string sciezka)
        {
            if (!System.IO.File.Exists(sciezka))
            {
                return new Database();
            }
            string json = System.IO.File.ReadAllText(sciezka);
            return System.Text.Json.JsonSerializer.Deserialize<Database>(json) ?? new Database();
        }
    }
}
