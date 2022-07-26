using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonJessyAccesoDatos;
using SalonJessyAccesoDatos.Models;
using SalonJessyAccesoDatos.Operaciones;

namespace SalonJessy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        [HttpGet(Name = "GetCita")]
        public List<OpCitas> Get(int telefono)
        {
         List<Citas> list = new List<Citas>();
            OpCitas op = new OpCitas();
            op.BuscarCitasCedula(telefono);
            return ;
        }

        [HttpPost]
        public void IngresarCita(int telefono, DateTime fechainicio, DateTime fechaFin, int servicio)
        {
            OpCitas op = new OpCitas();
            op.InsertarCita(telefono, fechainicio, fechaFin, servicio);
        }
        [HttpPut]
        public void ActualizarCita(int citaId, DateTime fechainicio, DateTime fechaFin)
        {
            OpCitas op = new OpCitas();
            op.ModificarCita(citaId, fechainicio, fechaFin);
        }

        [HttpDelete]
        public void EliminarCita(int citaId)
        {
            OpCitas op = new OpCitas();
            op.CancelarCita(citaId);
        }
    }
}

