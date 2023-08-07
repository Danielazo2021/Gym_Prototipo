using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms
{
    public class Alumno
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }        
        public int edad { get; set; }
        public  string sexo { get; set; }
        public string observaciones { get; set; } = null;
        public DateTime fechaAlta { get; set; }

    }
}
