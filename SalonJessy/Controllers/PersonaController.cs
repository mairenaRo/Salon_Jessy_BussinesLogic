using Microsoft.AspNetCore.Mvc;
using SalonJessyAccesoDatos;
using SalonJessyAccesoDatos.Operaciones;

namespace SalonJessy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : Controller
    {
        [HttpGet(Name = "GetPersona")]
        public List<Persona> Get()
        {
            List<Persona> list = new List<Persona>();

            return list;
        }

        [HttpPost]
        public void IngresarPersona(int cedula, string nombre, string apellido1, string apellido2)
        {
            Cliente op = new Cliente();
            op.InsertarCliente(cedula, nombre, apellido1, apellido2);
        }
        [HttpPut]
        public void ActualizarPersona(int cedula, string nombre, string apellido1, string apellido2)
        {
            Cliente op = new Cliente();
            op.ModificarCliente(cedula, nombre, apellido1, apellido2);
        }

        [HttpDelete]
        public void EliminarPersona(int cedula)
        {
            Cliente op = new Cliente();
            op.EliminarCliente(cedula);
        }
    }

}
