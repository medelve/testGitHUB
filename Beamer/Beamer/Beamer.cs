using System.Reflection.PortableExecutable;

namespace Beamer;

public class Beamer
{
    private bool _eingeschaltet;
    private string _raum;
    private int _restzeit;

    
    public Beamer(string raum, int restzeit)
    {
        Raum = raum;
        Restzeit = restzeit;
    }


    public Beamer()
    {
        Raum = "A1.23";
        Restzeit = 1000;
    }

//Getter und Setter zugleich also Property
    public bool Eingeschaltet { get; set; }

    public string Raum
    {get;set;}

    public int Restzeit
    {
        get { return _restzeit; }
        set
        {
            if (value > 1000)
            {
                _restzeit = 1000;
                throw new Exception("Die Restzeit darf maximal 1000 Stunden betragen" + "\n" + "Der Wert wurde auf 1000 gesetzt");
            }
            _restzeit = value;
        }
    }

    public void Einschalten()
    {
        if (Eingeschaltet == true)
        {
            throw new Exception("Der Beamer ist bereits eingeschaltet!");
        }
        Eingeschaltet = true;
    }
    
    public void Ausschalten()
    {
        if (Eingeschaltet == false)
        {
            throw new Exception("Der Beamer ist bereits ausgeschaltet!");
        }
        Eingeschaltet = false;
    }

    public void Reparieren()
    {
        if (Restzeit >= 950)
        {
            throw new Exception("Der Beamer ist im perfekten Zustand!");
        }
        Restzeit += 50;
    }

    public void RunterWerfen()
    {
        Eingeschaltet = false;
        Restzeit = 0;
    }

    public void PrintBeamer()
    {
        string jaNein = Eingeschaltet ? "ja" : "nein";

        Console.WriteLine($"Der Beamer hat folgende Werte:\nEingeschaltet: {jaNein}\nRaum: {Raum}\nRestzeit: {Restzeit} Stunden");
    }




    public override string ToString()
    {
        string jaNein = Eingeschaltet ? "ja" : "nein";
        return $"Der Beamer hat folgende Werte:\nEingeschaltet: {jaNein}\nRaum: {Raum}\nRestzeit: {Restzeit} Stunden";
    }

    
    
    
}