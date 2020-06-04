using System;

namespace Clases
{
    public enum Maximos
    {
        VelocidadMax = 10,
        DestrezaMax = 5,
        FuerzaMax = 10,
        NivelMax = 10,
        ArmaduraMax = 10,
        SaludMax = 100,
        DañoMax = 50000,
    }

    public class Personaje
    {
        string tipo;
        string nombre;
        string apodo;
        DateTime fechaNacimiento;
        int edad;
        int salud;
        int velocidad;
        int destreza;
        int fuerza;
        int nivel;
        int armadura;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
    
    
        public void CargarDatos(string nombre, string apodo, DateTime fecha)
        {
            string[] tiposPersonajes = { "Duende", "Caballero", "Mago", "Troll", "Humano" };
            Random rand = new Random();

            Tipo = tiposPersonajes[rand.Next(tiposPersonajes.Length)]; //Selecciona un tipo de personaje al azar
            Nombre = nombre;
            Apodo = apodo;
            FechaNacimiento = fecha;
            Edad = DateTime.Today.Year - fecha.Year;
            Salud = Convert.ToInt32(Maximos.SaludMax);
            Velocidad = rand.Next(Convert.ToInt32(Maximos.DestrezaMax));
            Destreza = rand.Next(Convert.ToInt32(Maximos.DestrezaMax));
            Fuerza = rand.Next(Convert.ToInt32(Maximos.FuerzaMax));
            Nivel = rand.Next(Convert.ToInt32(Maximos.NivelMax));
            Armadura = rand.Next(Convert.ToInt32(Maximos.ArmaduraMax));
        }

        public string[] MostrarDatos()
        {
            string[] datos = { Tipo , Nombre, Apodo, Convert.ToString(FechaNacimiento), Convert.ToString(Edad), Convert.ToString(Salud), Convert.ToString(Velocidad), Convert.ToString(Destreza),
            Convert.ToString(Fuerza), Convert.ToString(Nivel), Convert.ToString(Armadura)};

            return datos;
        }

        public int SimularCombate(Personaje Personaje1, Personaje Personaje2)
        {
            for (int i = 0; i < 3; i++)
            {
                int PoderDeDisparo = Personaje1.Destreza * Personaje1.Fuerza * Personaje1.Nivel;
                int EfectividadDeDisparo = (new Random().Next(100) + 1) / 100;
                int ValorDeAtaque = PoderDeDisparo * EfectividadDeDisparo;
                int PoderDeDefensa = Personaje2.Armadura * Personaje2.Velocidad;
                int DañoProvocado = ((ValorDeAtaque * EfectividadDeDisparo - PoderDeDefensa) / Convert.ToInt32(Maximos.DañoMax)) * 100;

                Personaje2.Salud -= DañoProvocado;
            }

            for (int i = 0; i < 3; i++)
            {
                int PoderDeDisparo = Personaje2.Destreza * Personaje2.Fuerza * Personaje2.Nivel;
                int EfectividadDeDisparo = (new Random().Next(100) + 1) / 100;
                int ValorDeAtaque = PoderDeDisparo * EfectividadDeDisparo;
                int PoderDeDefensa = Personaje1.Armadura * Personaje1.Velocidad;
                int DañoProvocado = ((ValorDeAtaque * EfectividadDeDisparo - PoderDeDefensa) / Convert.ToInt32(Maximos.DañoMax)) * 100;

                Personaje1.Salud -= DañoProvocado;
            }

            if (Personaje1.Salud == Personaje2.Salud)
            {
                return 0;
            } else if (Personaje1.Salud > Personaje2.Salud)
                {
                    return 1;
            } else
            {
                return 2;
            }
            }
        }
    
    
    }

    public static class Helper
    {
        public static DateTime FechaAleatoria(int anios)
        {
            Random gen = new Random();
            DateTime start = DateTime.Today.AddDays(-anios);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
