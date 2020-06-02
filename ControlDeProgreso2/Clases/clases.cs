using System;

namespace Clases
{
    enum maximos
    {
        VelocidadMax = 10,
        DestrezaMax = 5,
        FuerzaMax = 10,
        NivelMax = 10,
        ArmaduraMax = 10,
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
    }
}
