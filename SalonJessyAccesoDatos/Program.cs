
using SalonJessyAccesoDatos;
using SalonJessyAccesoDatos.Operaciones;


DateTime now =DateTime.Now;
TimeSpan hora = TimeSpan.Zero;
Cliente opCliente = new Cliente();
OpCitas opCitas1 = new OpCitas();
//opCliente.InsertarCliente(207900955,"Junior","Corrales","Madriz");
opCitas1.BuscarCitasCedula(12345678);
//opCitas1.CancelarCita(2);
Console.ReadLine();
