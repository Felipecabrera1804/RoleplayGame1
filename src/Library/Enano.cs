using System;

namespace Library
{
    public class Enano
    {
        public Enano(int fuerza, int defensa, int resistencia, Espada espada, Armadura armadura)
        {
            this.Ataque = fuerza + espada.Daño;
            this.Defensa = defensa + armadura.Defensa;
            this.Resistencia = resistencia + armadura.Resistencia;
        }
        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
    }
}