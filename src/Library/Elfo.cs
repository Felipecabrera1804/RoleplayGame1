using System;

namespace Library
{
    public class Elfo
    {
        public Elfo(int vida, string nombre, int fuerza, int defensa, int resistencia, int conocimiento, Lanza lanza, Armadura armadura, LibroHechizos libroHechizos)
        {
            this.Vida = vida;
            this.Nombre = nombre;
            this.Ataque = fuerza + lanza.Daño;
            this.Defensa = defensa + armadura.Defensa;
            this.Resistencia = resistencia + armadura.Resistencia;
            this.DañoMagico = conocimiento + libroHechizos.Daño;
        }
        public int Vida{get;set;}
        public string Nombre{get;set;}
        public int Defensa {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
        public int DañoMagico {get;set;}
    }
}