using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonJessyAccesoDatos.DataSets.DatosClienteTableAdapters;


namespace SalonJessyAccesoDatos.Operaciones
{
    public class Cliente
    {
        public void InsertarCliente(int telefono, string nombre, string primerApellido, string segundoApellido)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Persona_TelefonoTableAdapter();

            dataset.Agregar_Persona_SQLOnline(telefono, nombre,primerApellido,segundoApellido,null, null);

        }

        public Persona BuscarCliente (int buscar)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Persona_TelefonoTableAdapter();
            var resultCliente = dataset.GetDataPersona_Telefono_SQLOnline(buscar);
            
                Persona persona = new Persona();
            foreach (DataSets.DatosCliente.Buscar_Persona_TelefonoRow r in resultCliente.Rows)
            {
               persona.TelefonoID = r.TelefonoID;
                persona.Nombre = r.PrimerNombre;
                persona.PrimerApellido = r.PrimerApellido;
                persona.SegundoApellido = r.SegundoApellido;
                persona.Correo = r.Correo;
                persona.Contrasenna = r.Contrasenna;
            }

            return persona; 
        }
        //Modificar para cliente
        public void ModificarCliente(int telefono, string nombre, string primerApellido, string segundoApellido)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Persona_TelefonoTableAdapter();

            dataset.Modificar_Persona_SQLOnline(telefono, nombre, primerApellido, segundoApellido, null, null);

        }


        public void EliminarCliente(int telefono)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.Buscar_Persona_TelefonoTableAdapter();

            dataset.Borrar_Persona_SQLOnline(telefono);

        }
    }




}
