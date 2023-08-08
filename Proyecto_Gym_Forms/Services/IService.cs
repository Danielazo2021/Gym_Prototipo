using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.Services
{
    public interface IService
    {
        bool agregarAlumno(Alumno alumno);
        Alumno consultaAlumno(int dni);

        DataTable consultarAlumno(int dni);
        DataTable consultaAlumno(string  nombre);
        DataTable consultaAlumno(string nombre, string Apellido);
        bool actualizarAlumno(Alumno alumno);

        bool cobrarCuota(DatosCuotas datosCuotas);
        DataTable consultarCuotas(DateTime fecha);

        bool validarLogin(Login login);
        DataTable buscarProximosVencimientos(DateTime desde, DateTime hasta);
        bool registrarAsistencia(Asistencia asistencia);
    }
}
