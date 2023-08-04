using Proyecto_Gym_Forms.DataAccess;
using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.Services
{
    public class Service : IService

    {
        private IDAO dao;

        public Service()
        {
            dao = new DAO();
        }

        public bool actualizarAlumno(Alumno alumno)
        {
            return dao.actualizarAlumno(alumno);
        }

        public bool agregarAlumno(Alumno alumno)
        {
           return  dao.agregarAlumno(alumno);
        }

        public bool cobrarCuota(DatosCuotas datosCuotas)
        {
             return dao.cobrarCuota(datosCuotas);
        }

        public Alumno consultaAlumno(int dni)
        {
            return dao.consultaAlumno(dni);
        }

        public Alumno consultaAlumno(string nombre, string apellido)
        {
            return dao.consultaAlumno(nombre , apellido);
        }

        public List<DatosCuotas> consultarCuotas(DateTime fecha)
        {
            return dao.consultarCuotas(fecha);
        }

        public bool validarLogin(Login login)
        {
            return dao.validarLogin(login);
        }
    }
}
