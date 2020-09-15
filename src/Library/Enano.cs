using System;

namespace Library
{
    public class Enano
    {
        public Enano(string nombre, int vida, int fuerza, int defensa, int resistencia, Espada espada, Armadura armadura)
        {
            this.Nombre=nombre;
            this.Vida=vida;
            this.Ataque = fuerza + espada.Daño;
            this.Defensa = defensa + armadura.Defensa;
            this.Resistencia = resistencia + armadura.Resistencia;
        }
        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
        public string Nombre {get;set;}
        public int Vida {get;set;}
    }
}