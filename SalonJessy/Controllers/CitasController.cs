using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonJessyAccesoDatos.Operaciones;

namespace SalonJessy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        [HttpGet(Name = "GetCita")]
        //public List<Persona> Get()
        //{
       //     List<Persona> list = new List<Persona>();

          //  return list;
        //}

        [HttpPost]
        public void IngresarCita(int cedula, DateTime fecha, TimeSpan horaIncio, TimeSpan horaFin)
        {
            OpCitas op = new OpCitas();
            op.InsertarCita(cedula, fecha, horaIncio, horaFin);
        }
        [HttpPut]
        public void ActualizarPersona(int cedula, string nombre, string apellido1, string apellido2)
        {
            //Cliente op = new Cliente();
            //op.ModificarCliente(cedula, nombre, apellido1, apellido2);
        }

        [HttpDelete]
        public void EliminarPersona(int cedula)
        {
            //Cliente op = new Cliente();
            //op.EliminarCliente(cedula);
        }
    }
}

