using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Espada excalibur = new Espada(40);
            Espada myst = new Espada(20);
            Armadura hierro = new Armadura(5,3,20);
            Lanza gugnir = new Lanza(30);
            LibroHechizos fimbulvetr= new LibroHechizos("Fimbulvetr",15,60);
            Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);
            Enano eldigan = new Enano("Eldigan",50,25,20,5,myst,hierro);
            Elfo legolaz = new Elfo(150,"Legolaz",15,3,8,20,gugnir,hierro,fimbulvetr);
            Console.WriteLine();
            Console.WriteLine($"Legolaz HP:{legolaz.Vida}");
            Console.WriteLine("Gimli ataca a Legolaz");
            legolaz.Vida = Ataque.Atacar(gimli.Ataque,legolaz.Vida);
            Console.WriteLine($"Legolaz HP:{legolaz.Vida}");
            Console.WriteLine();
            Console.WriteLine($"Eldigan HP:{eldigan.Vida}");
            Console.WriteLine($"Eldigan ataque:{eldigan.Ataque}");
            Console.WriteLine($"Eldigan defensa:{eldigan.Defensa}");
            Console.WriteLine("Legolaz cura a Eldigan");
            eldigan.Vida = Curar.Curacion(legolaz.Cura,eldigan.Vida);
            Console.WriteLine($"Eldigan HP:{eldigan.Vida}");
        }
    }
}
