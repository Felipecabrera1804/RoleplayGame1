using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestElfo
    {
        [Test]
        public void Ataque_magico()
        {
            Espada excalibur = new Espada(40);
            Armadura hierro = new Armadura(5,3,20);
            Lanza gugnir = new Lanza(30);
            LibroHechizos fimbulvetr= new LibroHechizos("Fimbulvetr",15,60);
            Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);
            Elfo legolaz = new Elfo(150,"Legolaz",15,3,8,20,gugnir,hierro,fimbulvetr);
            gimli.Vida = Ataque.Atacar(legolaz.DañoMagico,gimli.Vida,gimli.Defensa);
            Assert.AreEqual(90,gimli.Vida);
        }

        [Test]
        public void Curacion()
        {
            Armadura hierro = new Armadura(5,3,20);
            Lanza gugnir = new Lanza(30);
            LibroHechizos fimbulvetr= new LibroHechizos("Fimbulvetr",15,60);
            Elfo legolaz = new Elfo(150,"Legolaz",15,3,8,20,gugnir,hierro,fimbulvetr);
            legolaz.Vida = Curar.Curacion(legolaz.Cura,legolaz.Vida);
            Assert.AreEqual(170,legolaz.Vida);
        }
    }
}