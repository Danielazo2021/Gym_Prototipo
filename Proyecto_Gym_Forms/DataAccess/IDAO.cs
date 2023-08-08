using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.DataAccess
{
    public interface IDAO
    {
        bool actualizarAlumno(Alumno alumno);
        bool agregarAlumno(Alumno alumno);
        DataTable buscarProximosVencimientos(DateTime desde, DateTime hasta);
        bool cobrarCuota(DatosCuotas datosCuotas);
        Alumno consultaAlumno(int dni);
        DataTable consultarAlumno(int dni);

        DataTable consultaAlumno(string nombre, string apellido);
        DataTable     consultaAlumno(string nombre);
        DataTable consultarCuotas(DateTime fecha);
        bool validarLogin(Login login);
    }
}
