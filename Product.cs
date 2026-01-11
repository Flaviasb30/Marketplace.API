namespace Marketplace.API.Models;

public class Product
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }

    public int VendedorId { get; set; }
    public User Vendedor { get; set; }
}
