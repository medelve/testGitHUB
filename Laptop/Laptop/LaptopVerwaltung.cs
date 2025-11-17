
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laptop.Modell
{
    public class LaptopVerwaltung
    {
        private List<Laptop> _laptops = new List<Laptop>();

        // Laptop aufnehmen (hinzufügen)
        public void Aufnehmen(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop), "Laptop darf nicht null sein.");
            }
            _laptops.Add(laptop);
        }

        // Laptop verkaufen (entfernen)
        public bool Verkaufen(Laptop laptop)
        {
            if (laptop == null) return false;
            return _laptops.Remove(laptop);
        }

        // Inventar anzeigen
        public override string ToString()
        {
            if (_laptops.Count == 0)
            {
                return "Inventar ist leer.";
            }

            string ausgabe = "Inventar:\n";
            foreach (var laptop in _laptops)
            {
                ausgabe += $"- Modell: {laptop.Modell}, Akku: {laptop.AkkuProzent}%, Am Netz: {laptop.AmNetz}, Betriebsbereit: {laptop.IsBetriebsbereit}\n";
            }
            return ausgabe;
        }

        // Zähle Laptops am Netz (foreach)
        public int ZaehleAmNetz_Foreach()
        {
            int count = 0;
            foreach (var laptop in _laptops)
            {
                if (laptop.AmNetz)
                {
                    count++;
                }
            }
            return count;
        }
        
        // Zähle Laptops am Netz (LINQ)
        public int ZaehleAmNetz_LINQ()
        {
            return _laptops.Count(l => l.AmNetz);
        }
    }
}
