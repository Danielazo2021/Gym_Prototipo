using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.DataAccess
{
    public interface IDAO
    {
        bool actualizarAlumno(Alumno alumno);
        bool agregarAlumno(Alumno alumno);
        bool cobrarCuota(DatosCuotas datosCuotas);
        Alumno consultaAlumno(int dni);
        Alumno consultaAlumno(string nombre, string apellido);
        List<DatosCuotas> consultarCuotas(DateTime fecha);
        bool validarLogin(Login login);
    }
}
