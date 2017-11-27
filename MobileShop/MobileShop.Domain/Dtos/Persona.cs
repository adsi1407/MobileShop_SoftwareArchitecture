using System;

namespace MobileShop.Domain.Dtos
{
    public class Persona: ObjetoGenerico
    {
        public TipoIdentificacion TipoIdentificacion { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }

        public EstadoPersona Estado { get; set; }
    }
}
