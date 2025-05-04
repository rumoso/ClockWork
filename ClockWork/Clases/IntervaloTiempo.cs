using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork.Clases
{
    public class IntervaloTiempo
    {
        public string sActividad { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public TimeSpan tiempoPausado { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
