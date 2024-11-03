using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Repositories;

namespace RazorCrudSample.Pages.Product
{
    public class UpdateModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        public UpdateModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public ProductDto productDto { get; set; } = new ProductDto();

        public async Task<IActionResult> OnGet(long?Id)
        {
            if (Id == null)
                return BadRequest();

             productDto = await _productRepository.GetProduct((long)Id);

            if (productDto == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            await _productRepository.UpdateProduct(productDto);
            return RedirectToPage("Index");
        }
    }
}
