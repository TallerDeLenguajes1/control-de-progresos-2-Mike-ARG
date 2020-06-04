using Clases;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ControlDeProgreso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantPersonajes = 20;
            List<Personaje> ListaDePersonajes = new List<Personaje>();
            string[] OpcionesDeNombres = { "Jon Dichie", "Carlos Menem", "Justin Timberlake", "Juan de los Palotes" };
            string[] OpcionesDeApodos = { "Yonk", "Yuxta", "Yonoeris", "Flyer", "El Pone Bombas" };
            Personaje MiPersonaje;

            for (int i = 0; i < cantPersonajes; i++)
            {
                MiPersonaje = new Personaje();
                string Nombre = OpcionesDeNombres[new Random().Next(OpcionesDeNombres.Length)];
                string Apodo = OpcionesDeApodos[new Random().Next(OpcionesDeApodos.Length)];
                DateTime FechaNac = Helper.FechaAleatoria(300);

                MiPersonaje.CargarDatos(Nombre, Apodo, FechaNac);
            }
        }
    }
}
