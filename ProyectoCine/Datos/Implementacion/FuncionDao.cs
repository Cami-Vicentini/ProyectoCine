using ProyectoCine.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Datos.Implementacion
{
    public class FuncionDao : IFuncionDao
    {
        public List<Funcion> GetFunciones(Pelicula pelicula)
        {
            List<Funcion> lFunciones = new List<Funcion>();
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_OBTENER_FUNCIONES", new Parametro("@id_pelicula", pelicula.IdPelicula));
            foreach (DataRow fila in tabla.Rows)
            {
                int idSala = int.Parse(fila["id_sala"].ToString());
                Funcion oFuncion = new Funcion(pelicula, idSala);
                oFuncion.FuncionId = int.Parse(fila["id_funcion"].ToString());
                DateTime dia = DateTime.Parse(fila["dia"].ToString());
                oFuncion.Dia = DateTime.Parse(dia.ToString(String.Format("yyyy-MM-dd")));
                DateTime hora = DateTime.Parse(fila["hora"].ToString());
                oFuncion.Hora = DateTime.Parse(dia.ToString(String.Format("HH:mm")));
                lFunciones.Add(oFuncion);
            }
            return lFunciones;
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperDao.GetInstancia().Consultar("SP_OBTENER_PELICULAS");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula.IdPelicula = int.Parse(fila["id_pelicula"].ToString());
                oPelicula.Titulo = fila["titulo"].ToString();
                oPelicula.Genero = fila["genero"].ToString();
                oPelicula.Director = fila["director"].ToString();
                oPelicula.Idioma = fila["idioma"].ToString();
                oPelicula.Duracion = int.Parse(fila["duracion"].ToString());
                oPelicula.Clasificacion = fila["clasificacion"].ToString();
                lPeliculas.Add(oPelicula);
            }
            return lPeliculas;
        }
    }
}
