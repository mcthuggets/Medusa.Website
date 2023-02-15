using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Medusa.Website.Services;
using Medusa.Website.Models;

namespace Medusa.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(
                            ILogger<IndexModel> logger,
                            JsonFileProductsService productService
                          )
        {
            _logger = logger;
            ProductService= productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}