using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestBestia
    {
        [Test]
        public void Ataque_bestial()
        {
            Mazo skullbreaker = new Mazo(34);
            Chaleco cuero = new Chaleco(3,2,25);
            Espada whirlwind = new Espada(39);
            Armadura hierro = new Armadura(5,3,20);
            Bestia ciclope = new Bestia("Polifemo",100,35,20,5,skullbreaker,cuero);
            Enano hreidmar = new Enano("Hreidmar",112,20,20,6,whirlwind,hierro);
            ciclope.Vida = Ataque.Atacar(ciclope.Ataque,hreidmar.Vida,hreidmar.Defensa);
            Assert.AreEqual(58,hreidmar.Vida);
        }
    }
}