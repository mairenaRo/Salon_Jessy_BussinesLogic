namespace SalonJessyAccesoDatos
{
    public class Persona
    {
        public int ? TelefonoID { get; set; }
        public string ? Nombre { get; set; }
        public string ? PrimerApellido { get; set; }
        public string ? SegundoApellido { get; set; }
        public string ? Correo { get; set; }
        public string ? Contrasenna { get; set; }

        public Persona() { }

        public Persona(int? telefonoID, string? nombre, string? primerApellido, string? segundoApellido, string? correo, string? contrasenna)
        {
            this.TelefonoID = telefonoID;
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Correo = correo;
            this.Contrasenna = contrasenna;
        }
    }

}
