using System;

namespace Library
{
    public class Bestia
    {
        public Bestia(String nombre, int fuerza, int vida, int defensa, int resistencia, Mazo mazo, Chaleco chaleco)
        {
            this.Nombre=nombre;
            this.Vida=vida;
            this.Ataque = fuerza + mazo.Daño;
            this.Defensa = defensa + chaleco.Defensa;
            this.Resistencia = resistencia + chaleco.Resistencia;
        }
        public string Nombre {get;set;}
        public int Vida {get;set;}
        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
        
    }
}