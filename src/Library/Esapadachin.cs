using System;

namespace Library
{
    public class Espadachin
    {

        public Espadachin(String nombre, int vida, int ataque, int defensa, int resistencia, Escudo escudo)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa + escudo.Defensa;
            this.Resistencia = resistencia;
        }

        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
        public string Nombre {get;set;}
        public int Vida {get;set;}

    }
}