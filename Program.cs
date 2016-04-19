using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador UnJugador = new Jugador(10, "Franco", "River", 15);

            UnJugador.Agregar(UnJugador);

            Console.ReadKey();
        }
    }
}
