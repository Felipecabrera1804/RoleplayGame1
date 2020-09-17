using NUnit.Framework;
using Library;


namespace Test.Library
{


    public class TestMago
    {

        private Baston vara;
        private Tunica gucci;
        private Espada excalibur;
        private  Mago gandalf;
        private Armadura hierro;

        private Lanza gugnir; 

        private Enano gimli;

       [Test]

//validacion al crear objeto, correctos atributo para ataque del mago 

        public void ValidValueAttack ()
        {
        Baston vara = new Baston (50,90,95);
        Tunica gucci = new Tunica (0,20,10);
        Espada excalibur = new Espada(40);
        Armadura hierro = new Armadura(5,3,20);
        Lanza gugnir = new Lanza(30);
        Mago gandalf = new Mago("Gandalf", 10 , 20, 40, 60, 25, vara, gucci);
        Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);

        Assert.AreEqual(90,gandalf.Ataque);
        }


//validacion al crear objeto, correctos atributo para ataque del mago 
  [Test]

        public void ValidValueResistance ()
        {
        Baston vara = new Baston (50,90,95);
        Tunica gucci = new Tunica (0,20,10);
        Espada excalibur = new Espada(40);
        Armadura hierro = new Armadura(5,3,20);
        Lanza gugnir = new Lanza(30);
        Mago gandalf = new Mago("Gandalf", 10 , 20, 40, 60, 25, vara, gucci);
        Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);

        Assert.AreEqual(45,gandalf.Resistencia);
        }


[Test]
         public void ValidValueDefense ()
        {
        Baston vara = new Baston (50,90,95);
        Tunica gucci = new Tunica (0,20,10);
        Espada excalibur = new Espada(40);
        Armadura hierro = new Armadura(5,3,20);
        Lanza gugnir = new Lanza(30);
        Mago gandalf = new Mago("Gandalf", 10 , 20, 40, 60, 25, vara, gucci);
        Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);
     
        Assert.AreEqual(60,gandalf.Defensa);
        }
        


//validacion sobre el ataque sobre la vida del mago, verificar vida nueva Mago

[Test]
        public void valorAtaque()
    {
         Baston vara = new Baston (50,90,95);
        Tunica gucci = new Tunica (0,20,10);
        Espada excalibur = new Espada(40);
        Armadura hierro = new Armadura(5,3,20);
        Lanza gugnir = new Lanza(30);
        Mago gandalf = new Mago("Gandalf", 10 , 20, 40, 60, 25, vara, gucci);
        Enano gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);

       
         Assert.AreEqual(5,Ataque.Atacar(gimli.Ataque, gandalf.Vida, gandalf.Defensa));
    

    }






    }

}
