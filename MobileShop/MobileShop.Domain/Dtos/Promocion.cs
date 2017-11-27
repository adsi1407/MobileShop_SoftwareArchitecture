using System;

namespace MobileShop.Domain.Dtos
{
    public class Promocion
    {
        public string Id { get; set; }

        public double Porcentaje { get; set; }

        public Producto Producto { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
