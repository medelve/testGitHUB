using System;

namespace BeamerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Beamer b1 = new Beamer(); // Standard-Konstruktor
            b1.PrintBeamer();

            Beamer b2 = new Beamer("B2.15", 900);
            b2.Einschalten();
            b2.PrintBeamer();

            b2.Reparieren();
            Console.WriteLine(b2); // ruft ToString() automatisch auf

            b2.RunterWerfen();
            b2.PrintBeamer();
        }
    }
}