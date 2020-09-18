using System;

namespace Library
{
    public class Armadura
    {
        public Armadura(int defensa, int resistencia, int durabilidad)
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
            //se puede romper eliminando su aporte a la defensa y resistencia
            this.Durabilidad = this.Durabilidad - 1;
            if (this.Durabilidad==0)
            {
                this.Defensa=0;
                this.Resistencia=0;
            }
        }
    }
}