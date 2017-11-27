namespace MobileShop.Domain.Dtos
{
    public class DetalleFactura
    {
        public string Id { get; set; }

        public Factura Factura { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}
