using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Repositories;

namespace RazorCrudSample.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        public CreateModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public ProductCreationDto productCreationDto { get; set; } = new ProductCreationDto();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            await _productRepository.CreateProduct(productCreationDto);
            return RedirectToPage("Index");

        }    


    }
}
