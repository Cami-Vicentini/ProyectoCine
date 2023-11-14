using ProyectoCine.Datos.Implementacion;
using ProyectoCine.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Servicios
{
    public class Servicios:IServicio
    {
        private IFuncionDao dao;
        
        public Servicios()
        {
            dao = new FuncionDao();
        }

        public bool CrearFuncion(Funcion oFuncion)
        {
            throw new NotImplementedException();
        }
        //public bool CrearFuncion(Funcion oFuncion)
        //{
        //    return dao.Crear(oFuncion);
        //}

    }
}
