using Store.Api.Models;
using Store.Api.Repositories.Interfaces;

namespace Store.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IReadOnlyCollection<Product> GetAll()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Soverte de Morango",
                    Description = "Sorvete de Morango top",
                    Price = 5,
                    Image = new Uri("https://img.cybercook.com.br/receitas/815/sorvete-de-morango-vegano.jpeg")
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Soverte de Chocolate",
                    Description = "Sorvete de Chocolate Melhor",
                    Price = 10,
                    Image = new Uri("https://cozinhaemsegundos.com.br/imagem.php?imagem=images/receitas/1200_receita-de-sorvete-de-chocolate.jpeg&largura=1116&altura=628")
                }
            };

            return products;
        }
    }
}
