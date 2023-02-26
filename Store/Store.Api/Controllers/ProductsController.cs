using Microsoft.AspNetCore.Mvc;
using Store.Api.Repositories.Interfaces;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Iniciando requisição para obter todos os produtos");
            var products = _productRepository.GetAll();
            return Ok(products);
        }
    }
}