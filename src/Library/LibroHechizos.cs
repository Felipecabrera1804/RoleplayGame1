using System;

namespace Library
{
    public class LibroHechizos
    {
        public LibroHechizos(string nombre, int daño, int durabilidad)
        {
            this.Daño = daño;
            this.Nombre = nombre;
            this.Durabilidad = durabilidad;
        }
        public int Daño {get;set;}
        public string Nombre {get;set;}
        public int Durabilidad {get;set;}
        public void Desgaste()
        {
            this.Durabilidad -= 1;
            if(this.Durabilidad==0)
            {
                this.Daño=0;
            }
        }
    }
}