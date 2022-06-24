
using SalonJessyAccesoDatos;
using SalonJessyAccesoDatos.Operaciones;


DateTime now =DateTime.Now;
TimeSpan hora = TimeSpan.Zero;
Cliente opCliente = new Cliente();
OpCitas opCitas1 = new OpCitas();
opCitas1.InsertarCita(207900955, now, hora, hora);
Console.ReadLine();
