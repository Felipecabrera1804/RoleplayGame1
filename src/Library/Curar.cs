using System;

namespace Library
{
    public class Curar
    {
        public static int Curacion(int cura, int vida)
        {
            vida=vida + cura;
            return vida;
        }
    }
}