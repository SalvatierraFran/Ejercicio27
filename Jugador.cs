using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio27
{
    class Jugador
    {
        public int golesConvertidos;
        public string nombre;
        public string nombreEquipo;
        public int partidosJugados;
        public float promedioDeGol;

        public List<Jugador> ListaDeJugadores;

        public Jugador(int Goles, string Nombre, string Equipo, int PJ)
        {
            this.golesConvertidos = Goles;
            this.nombre = Nombre;
            this.nombreEquipo = Equipo;
            this.partidosJugados = PJ;

            this.ListaDeJugadores = new List<Jugador>();
        }

        public void Agregar(Jugador UnJugador)
        {
            this.ListaDeJugadores.Add(UnJugador);
        }

    }
}
