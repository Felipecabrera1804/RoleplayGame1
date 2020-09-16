using System;

namespace Library
{
    public class Ataque
    {
        public static int Atacar(int ataque, int vida)
        {
            vida=vida - ataque;
            if(vida<0)
            {
               vida=0; 
            }
            return vida;
        }
    }
}