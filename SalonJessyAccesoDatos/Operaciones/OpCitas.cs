using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonJessyAccesoDatos.Operaciones
{
    public class OpCitas
    {
        public void InsertarCita(int cedula, DateTime fecha, TimeSpan horaIncio, TimeSpan horaFin)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.CitaTableAdapter();

            dataset.Agregar_Cita(1,cedula,fecha, horaIncio, horaFin);

        }
    }
}
