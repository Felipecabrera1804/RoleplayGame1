using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void Vida_despues_de_ataque()
        {
            Espada excalibur = new Espada(40);
            Armadura hierro = new Armadura(5,3,20);
            Lanza gugnir = new Lanza(30);
            LibroHechizos fimbulvetr= new LibroHechizos("Fimbulvetr",15,60);
            Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);
            Elfo legolaz = new Elfo(150,"Legolaz",15,3,8,20,gugnir,hierro,fimbulvetr);
            legolaz.Vida = Ataque.Atacar(gimli.Ataque,legolaz.Vida,legolaz.Defensa);
            Assert.AreEqual(93,legolaz.Vida);
        }

    }


}