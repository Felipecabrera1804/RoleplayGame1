using System;

namespace Library
{
    public class Ataque
    {
        public static int Atacar(int ataque, int vida, int aguante)
        {
            // Devuelve una cantidad de vida reducida, en base al daño recibido
            int nuevavida=vida + aguante - ataque;
            if(nuevavida<=vida)
            {
                vida = nuevavida;
            }
            if(vida<0)
            {
               vida=0; 
            }
            return vida;
        }
    }
}