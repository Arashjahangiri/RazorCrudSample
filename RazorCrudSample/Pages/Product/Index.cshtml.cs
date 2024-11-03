using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Repositories;

namespace RazorCrudSample.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public IndexModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductDto> Products { get; set; } = new List<ProductDto>();

        public async Task OnGet()
        {

            Products = await _productRepository.GetProducts();

        }
    }
}
