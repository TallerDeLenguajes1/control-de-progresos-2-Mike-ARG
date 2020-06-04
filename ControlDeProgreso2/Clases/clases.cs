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
    
    
        public Personaje CargarDatos(Personaje Personaje)
        {
            string[] tiposPersonajes = { "Duende", "Caballero", "Mago", "Troll", "Humano" };
            Random rand = new Random();

            Personaje.Tipo = tiposPersonajes[rand.Next(tiposPersonajes.Length)]; //Selecciona un tipo de personaje al azar

            Console.WriteLine("Ingrese el nombre del personaje: ");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apodo del personaje: ");
            Personaje.Apodo = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento del personaje: ");
            Personaje.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Personaje.Edad = DateTime.Now.Year - Personaje.FechaNacimiento.Year;
            Personaje.Salud = Convert.ToInt32(Maximos.SaludMax);
            Personaje.Velocidad = rand.Next(Convert.ToInt32(Maximos.DestrezaMax));
            Personaje.Destreza = rand.Next(Convert.ToInt32(Maximos.DestrezaMax));
            Personaje.Fuerza = rand.Next(Convert.ToInt32(Maximos.FuerzaMax));
            Personaje.Nivel = rand.Next(Convert.ToInt32(Maximos.NivelMax));
            Personaje.Armadura = rand.Next(Convert.ToInt32(Maximos.ArmaduraMax));


            return Personaje;
        }
    
    
    }
}
