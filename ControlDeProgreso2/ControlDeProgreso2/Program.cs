using Clases;
using System;
using System.Runtime.CompilerServices;

namespace ControlDeProgreso2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje MiPersonaje = new Personaje();
            DateTime fechaAleatoria = Helper.FechaAleatoria(300);
            MiPersonaje.CargarDatos("Pablo", "El Jefe", fechaAleatoria);
        }
    }
}
