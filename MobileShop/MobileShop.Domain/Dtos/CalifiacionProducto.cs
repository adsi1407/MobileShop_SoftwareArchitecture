namespace MobileShop.Domain.Dtos
{
    public class CalifiacionProducto
    {
        public string Id { get; set; }

        public int Valor { get; set; }

        public string Comentario { get; set; }

        public Persona PersonaCalifica { get; set; }

        public Producto Producto { get; set; }
    }
}
