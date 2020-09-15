using System;

namespace Library
{
    public class Chaleco
    {
        public Chaleco(int defensa, int resistencia, int durabilidad)
        {
            this.Defensa = defensa;
            this.Resistencia = resistencia;
            this.Durabilidad = durabilidad;
        }
        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Durabilidad {get;set;}
        public void Desgaste()
        {
            this.Durabilidad -= 1;
        }
    }
}