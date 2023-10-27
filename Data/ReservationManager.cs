using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BlazorHybridApp2.Data
{
    public class ReservationManager
    {
        private static readonly string RESERVATIONS_JSON_FILE = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "reservations.json");

        protected List<Reservation> _reservations;

        public IList<Reservation> Reservations
        {
            get { return _reservations; }
        }

        public ReservationManager()
        {
            _reservations = LoadFromFile();
        }

        public void Save()
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(_reservations);
                File.WriteAllText(RESERVATIONS_JSON_FILE, jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        private List<Reservation> LoadFromFile()
        {
            if (File.Exists(RESERVATIONS_JSON_FILE))
            {
                var jsonString = File.ReadAllText(RESERVATIONS_JSON_FILE);
                return JsonSerializer.Deserialize<List<Reservation>>(jsonString);
            }
            else
            {
                return new List<Reservation>();
            }
        }
    }
}