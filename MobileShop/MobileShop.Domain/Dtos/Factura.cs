using System;

namespace MobileShop.Domain.Dtos
{
    public class Factura
    {
        public string Id { get; set; }

        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }

        public MetodoPago MetodoPago { get; set; }
    }
}
