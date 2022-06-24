using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonJessyAccesoDatos.Models
{
    public class Citas
    {
        public int CitaId { get; set; }
        public int EstadoId { get; set; }
        public int CedulaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        }
    }

