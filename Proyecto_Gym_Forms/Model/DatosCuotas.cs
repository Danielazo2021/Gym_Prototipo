using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.Model
{
    public class DatosCuotas
    {
        public int idCuota { get; set; }
        public Alumno alumno { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string observaciones { get; set; }
    }
}
