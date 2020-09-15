using System;

namespace Library
{
    public class Baston
    {
        private int daño;
        private int resistencia;
        private int durabilidad;
        public Baston(int daño, int resistencia, int durabilidad)
        {
            this.Daño = daño;
            this.Resistencia=resistencia;
            this.Durabilidad=durabilidad;

        }
        public int Daño {get;set;}
        public int Resistencia {get;set;}
        public int Durabilidad {get;set;}

        public void Desgaste()
        {
            this.Durabilidad -= 1;
            if (this.Durabilidad==0)
            {
                this.Daño=0;
            }
        }
    }
}