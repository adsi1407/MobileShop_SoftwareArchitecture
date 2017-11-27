using System;

namespace MobileShop.Domain.Dtos
{
    public class Busqueda
    {
        public string Id { get; set; }

        public DateTime Fecha { get; set; }

        public Producto Producto { get; set; }

        public Persona Persona { get; set; }
    }
}
