using System;
using BeamerConsole;

var beamer1 = new Beamer();
beamer1.PrintBeamer();

var beamer2 = new Beamer("B2.15",900);
beamer2.Einschalten();
beamer2.PrintBeamer();

beamer2.Reparieren();
Console.WriteLine(beamer2);

beamer2.RunterWerfen();
beamer2.PrintBeamer();

    
    
   