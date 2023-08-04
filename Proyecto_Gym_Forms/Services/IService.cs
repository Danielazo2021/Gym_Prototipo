using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.Services
{
    public interface IService
    {
        bool agregarAlumno(Alumno alumno);
        Alumno consultaAlumno(int dni);
        Alumno consultaAlumno(string nombre, string Apellido);
        bool actualizarAlumno(Alumno alumno);

        bool cobrarCuota(DatosCuotas datosCuotas);
        List<DatosCuotas> consultarCuotas(DateTime fecha);

        bool validarLogin(Login login);



    }
}
