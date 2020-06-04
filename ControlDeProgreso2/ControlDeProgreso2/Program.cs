using Clases;
using System;

namespace ControlDeProgreso2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje MiPersonaje = new Personaje();
            Random valoresAleatorios = new Random();
            valoresAleatorios.Next(100);
            Console.WriteLine("Hello World!");
        }
    }
}
