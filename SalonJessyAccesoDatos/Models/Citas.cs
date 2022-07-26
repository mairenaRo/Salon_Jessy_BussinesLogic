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
        public int telefonoId { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }

        public Citas() { }

        public Citas(int ? citaID, int estadoID, int telefono, DateTime fechaInicio, DateTime fechaFin) {

            this.CitaId = CitaId;
            this.EstadoId = estadoID;
            this.telefonoId = telefono; 
            this.FechaHoraInicio = fechaInicio;
            this.FechaHoraFin = fechaFin;
        }
    }
}

