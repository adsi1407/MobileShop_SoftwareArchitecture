namespace MobileShop.Domain.Dtos
{
    public class Categoria: ObjetoGenerico
    {
        public string Descripcion { get; set; }

        public string CategoriaPadre { get; set; }
    }
}
