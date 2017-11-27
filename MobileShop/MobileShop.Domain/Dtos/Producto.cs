namespace MobileShop.Domain.Dtos
{
    public class Producto: ObjetoGenerico
    {
        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public Vendedor Vendedor { get; set; }

        public Categoria Categoria { get; set; }

        public EstadoPublicacion Estado { get; set; }

        public UsoProducto Uso { get; set; }
    }
}
