using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Data.Models
{
    public class Vuelo
    {
        public int Id { get; set; }
        public string NumeroDeVuelo { get; set; }
        public DateTime FechaYHorarioDeLlegada { get; set; }
        public string LineaAerea { get; set; }
        public bool Demorado { get; set; }
    }
}
