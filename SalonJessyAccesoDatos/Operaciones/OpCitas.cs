using SalonJessyAccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonJessyAccesoDatos.Operaciones
{
    public class OpCitas
    {
        public void InsertarCita(int telefono, DateTime fechaInicio, DateTime fechaFin, int servicio)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Cita_TelefonoTableAdapter();

            dataset.Agregar_Cita_SQLOnline(1, telefono, fechaInicio, fechaFin, servicio);

        }

        public List<Citas> BuscarCitasCedula(int buscar)
        {

           Citas cita;
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Cita_TelefonoTableAdapter();
            var resultCita = dataset.GetDataCitaTelefono_SQLOnline(buscar);
            var lista = new List<Citas>();
            

            foreach (DataSets.DatosCliente.Buscar_Cita_TelefonoRow r in resultCita.Rows)
            {
                Citas citatemp =new Citas(r.CitaID, r.EstadoID, r.TelefonoID, r.FechaHoraInicio, r.FechaHoraFin);
                lista.Add(citatemp);
            }

            return lista;
        }
        public void ModificarCita(int citaId, DateTime fechaInicio, DateTime fechaFin)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Cita_TelefonoTableAdapter();

            dataset.Modificar_Fecha_Cita_SQLOnline(citaId, fechaInicio,fechaFin);

        }
        public void CancelarCita(int citaId)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Cita_TelefonoTableAdapter();

            dataset.Borrar_Cita_SQLOnline(citaId);

        }
    }


}
