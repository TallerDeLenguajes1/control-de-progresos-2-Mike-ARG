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
                ListaDePersonajes.Add(MiPersonaje);
            }

            Personaje Personaje1 = ListaDePersonajes[0];
            Personaje Personaje2 = ListaDePersonajes[1];

            for (int i = 0; i < 3; i++)
            {
                Personaje1.Atacar(Personaje2);
                Personaje2.Atacar(Personaje1);
            }

            if (Personaje1.Salud > Personaje2.Salud)
            {
                ListaDePersonajes.Remove(Personaje2);
                Personaje1.Salud = Convert.ToInt32(Maximos.SaludMax);
                Personaje1.Salud += 10;
            } else if (Personaje1.Salud < Personaje2.Salud)
            {
                ListaDePersonajes.Remove(Personaje1);
                Personaje2.Salud = Convert.ToInt32(Maximos.SaludMax);
                Personaje2.Salud += 10;
            }

        }
    }
}
