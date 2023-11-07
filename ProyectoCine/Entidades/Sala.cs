using System.Collections.Generic;

namespace ProyectoCine.Datos.Interfaz
{
    public class Sala
    {
        public enum Tipo_Sala
        {
            _2D, //las enumeraciones de C# no pueden comenzar con un número por eso el _
            _3D
        }
        public int IdSala { get; set; }
        public string TipoSala { get; set; }
        public List<Butaca> Butacas { get; set; }
        public Sala(int idSala)
        {
            IdSala = idSala;
            TipoSala = null;
            Butacas = new List<Butaca>();
        }
        public Sala(int idSala, string tipoSala)
        {
            IdSala = idSala;
            TipoSala = tipoSala;
            Butacas = new List<Butaca>();
        }
    }
}