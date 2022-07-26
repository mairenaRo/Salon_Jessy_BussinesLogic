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
        public Persona Get(int telefono)
        {
            Persona persona = new Persona();
            Cliente cliente = new Cliente();

            persona = cliente.BuscarCliente(telefono);
            
            return persona;
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
