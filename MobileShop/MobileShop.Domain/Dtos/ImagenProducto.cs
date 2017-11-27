namespace MobileShop.Domain.Dtos
{
    public class ImagenProducto
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Descripcion { get; set; }

        public Producto Producto { get; set; }
    }
}
