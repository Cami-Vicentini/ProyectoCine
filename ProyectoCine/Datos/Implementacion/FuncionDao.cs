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
        public bool ButacasDisponibles(Funcion funcion, int cantidad)
        {
            bool verificacion = true;
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_ESTADOS_BUTACA", new Parametro("@funcion", funcion.FuncionId));
            int cantDisponible = 48 - tabla.Rows.Count; 
            if (cantidad > cantDisponible)
            {
                verificacion = false;
            }
            return verificacion;
        }

        public List<Butaca> GetButacas(Funcion funcion)
        {

            List<Butaca> lButacas = new List<Butaca>();
            DataTable tablaButacas = HelperDao.GetInstancia().ConsultarConParam("SP_OBTENER_BUTACAS", new Parametro("@id_sala", funcion.oSala.IdSala));
            DataTable tablaEstados = HelperDao.GetInstancia().ConsultarConParam("SP_ESTADOS_BUTACA", new Parametro("@funcion", funcion.FuncionId));
            foreach (DataRow fila in tablaButacas.Rows)
            {
                Butaca b = new Butaca();
                b.NroButaca = int.Parse(fila["id_butaca"].ToString());
                b.FilaCol = fila["numero"].ToString();
                if (tablaEstados.Rows.Count > 0)
                {
                    foreach (DataRow filaEstados in tablaEstados.Rows)
                    {
                        if (b.NroButaca == int.Parse(filaEstados["id_butaca"].ToString()))
                        {
                            b.Estado = Estado.Ocupado;
                        }
                    }
                }
                else
                {
                    b.Estado = Estado.Libre;
                }
                lButacas.Add(b);
            }

            

            return lButacas;
        }

        public List<Funcion> GetFunciones(Pelicula pelicula)
        {
            List<Funcion> lFunciones = new List<Funcion>();
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_OBTENER_FUNCIONES", new Parametro("@id_pelicula", pelicula.IdPelicula));
            foreach (DataRow fila in tabla.Rows)
            {
                Sala oSala = new Sala(int.Parse(fila["id_sala"].ToString()), fila["descripcion"].ToString());
                Funcion oFuncion = new Funcion(pelicula, oSala);
                oFuncion.FuncionId = int.Parse(fila["id_funcion"].ToString());
                DateTime dia = DateTime.Parse(fila["dia"].ToString());
                oFuncion.Dia = dia.ToString(String.Format("M"));
                DateTime hora = DateTime.Parse(fila["hora"].ToString());
                oFuncion.Hora = hora.ToString("t");
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
