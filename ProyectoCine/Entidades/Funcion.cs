using System;

namespace ProyectoCine.Datos.Interfaz
{
    public class Funcion
    {
        public int FuncionId { get; set; }
        public Pelicula oPelicula { get; set; }
        public Sala oSala { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }

        public Funcion()
        {
            FuncionId = 0;
            oPelicula = null;
            oSala = new Sala();
        }
        public Funcion(Pelicula pelicula, Sala sala)//Siempre una funcion va a tener una pelicula
        {
            FuncionId = 0;
            oPelicula = pelicula;
            oSala = sala;
            Dia = string.Empty;
            Hora = string.Empty;
        }
        public Funcion(int id, Pelicula pelicula, Sala sala, string dia, string hora)
        {
            FuncionId = id;
            oPelicula = pelicula;
            oSala = sala;
            Dia = dia;
            Hora = hora;
        }
    }
}