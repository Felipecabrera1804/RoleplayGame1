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
        private Elfo elfi;
        private LibroHechizos fimbulvetr;

 [SetUp]
        public void SetUp(){
              this.vara= new Baston (50,90,95);
              this.gucci= new Tunica (0,20,10);
              this.excalibur= new Espada(40);
              this.gandalf =new Mago("Gandalf", 10 , 20, 40, 60, 25, vara, gucci);
              this.hierro= new Armadura(5,3,20);
              this.gugnir= new Lanza(30);
              this.gimli = new Enano("Gimli",100,25,20,5,excalibur,hierro);
              this.fimbulvetr= new LibroHechizos("Fimbulvetr",15,60);
              this.elfi= new Elfo(20,"Elfi",25,50,40,60,gugnir,hierro,fimbulvetr);

        }
       [Test]

//validacion al crear objeto, correctos atributo para ataque del mago 

        public void ValidValueAttack ()
        {

        Assert.AreEqual(90,gandalf.Ataque);
        }


//validacion al crear objeto, correctos atributo para ataque del mago 
  [Test]

        public void ValidValueResistance ()
        {
            Assert.AreEqual(45,gandalf.Resistencia);
        }


[Test]
         public void ValidValueDefense ()
        {
        Assert.AreEqual(60,gandalf.Defensa);
        }
        


//validacion sobre el ataque sobre la vida del mago, verificar vida nueva Mago

[Test]
        public void valorAtaque()
    {
        Assert.AreEqual(5,Ataque.Atacar(gimli.Ataque, gandalf.Vida, gandalf.Defensa));
   
    }


//validacion curacion mago, verificar vida nueva Mago

[Test]
        public void valorCuracion()
    {
        Assert.AreEqual(30,Curar.Curacion(elfi.Cura,gandalf.Vida));
   
    }




    }

}
