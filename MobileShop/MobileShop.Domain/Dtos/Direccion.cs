namespace MobileShop.Domain.Dtos
{
    public class Direccion
    {
        public string Id { get; set; }

        public Persona Persona { get; set; }

        public string Descripcion { get; set; }

        public Ciudad Ciudad { get; set; }

        public string PuntoReferencia { get; set; }
    }
}
