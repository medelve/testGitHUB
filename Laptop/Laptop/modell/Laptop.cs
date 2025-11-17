namespace Laptop.Modell
{
    public class Laptop
    {
        private string _modell;

        public string Modell
        {
            get { return _modell; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Modell), "Modell darf nicht null oder leer sein.");
                }
                _modell = value;
            }
        }

        private int _akkuProzent;

        public int AkkuProzent
        {
            get { return _akkuProzent; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(AkkuProzent), "AkkuProzent muss zwischen 0 und 100 liegen.");
                }
                _akkuProzent = value;
            }
        }

        public bool AmNetz { get; set; }

        public bool IsBetriebsbereit
        {
            get
            {
                return AmNetz || AkkuProzent > 5;
            }
        }
    }
    
    
    
}