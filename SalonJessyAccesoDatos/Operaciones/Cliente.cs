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
        public void InsertarCliente(int cedula, string nombre, string primerApellido, string segundoApellido)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.PersonaTableAdapter();

            dataset.Agregar_Persona(cedula,nombre,primerApellido,segundoApellido,(byte)1,null, null);

        }

        public Persona BuscarCliente (int buscar)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.PersonaTableAdapter();
            var resultCliente = dataset.GetDatosCliente(buscar);

            Persona persona = new Persona();

            //persona.Id = int.Parse(resultCliente.CedulaIDColumn.ColumnName);
            //persona.Nombre = resultCliente.PrimerNombreColumn.ColumnName;
            //persona.PrimerApellido = resultCliente.PrimerApellidoColumn.ColumnName;
            //persona.SegundoApellido = resultCliente.SegundoApellidoColumn.ColumnName;
            return persona; 
        }
        //Modificar para cliente
        public void ModificarCliente(int cedula, string nombre, string primerApellido, string segundoApellido)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.PersonaTableAdapter();

            dataset.Modificar_Persona(cedula, nombre, primerApellido, segundoApellido, (byte)1, null, null);

        }


        public void EliminarCliente(int cedula)
        {
            var dataset = new DataSets.DatosClienteTableAdapters.PersonaTableAdapter();

            dataset.Borrar_Cliente(cedula);

        }
    }




}
