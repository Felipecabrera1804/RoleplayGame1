using System;

namespace Library
{
    public class Mago
    {
        private string nombre;
        private int vida;
        private int durabilidad;
        private int conocimiento;
        private int defensa;
        private int resistencia;
        
        public Mago(string nombre, int vida, int durabilidad, int conocimiento, int defensa, int resistencia, Baston baston, Tunica tunica)
        {
            this.Nombre= nombre;
            this.Vida = vida;
            this.Ataque = conocimiento + baston.Daño;
            this.Defensa = defensa + tunica.Defensa;
            this.Resistencia = resistencia + tunica.Resistencia;
            this.Conocimiento= conocimiento;
        }
        public int Defensa {get;set;}
        public int Conocimiento {get;set;}
        public int Resistencia {get;set;}
        public int Ataque {get;set;}
        public string Nombre {get;set;}
        public int Vida {get;set;}
    }
}