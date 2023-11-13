using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Funcion> GetFunciones(Pelicula id_pelicula);//Devuelve las funciones según la película enviada por parametro
        List<Pelicula> GetPeliculas(); //Mapea peliculas para cargar el combo
        List<Butaca> GetButacas(Funcion funcion); //Trae lista de butacas de la sala ingresada por parametro
        bool ButacasDisponibles(Funcion funcion, int cantidad);
    }
}
