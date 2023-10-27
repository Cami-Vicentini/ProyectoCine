using System;

namespace ProyectoCine.Datos.Interfaz
{
    public class Funcion
    {
        public int FuncionId { get; set; }
        public Pelicula oPelicula { get; set; }
        public Sala oSala { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public Funcion(Pelicula pelicula, int idSala)//Siempre una funcion va a tener una pelicula
        {
            FuncionId = 0;
            oPelicula = pelicula;
            oSala = new Sala(idSala);
            Dia = DateTime.Now;
            Hora = DateTime.Now;
        }
        public Funcion(int id, Pelicula pelicula, Sala sala, DateTime dia, DateTime hora)
        {
            FuncionId = id;
            oPelicula = pelicula;
            oSala = sala;
            Dia = dia;
            Hora = hora;
        }
    }
}