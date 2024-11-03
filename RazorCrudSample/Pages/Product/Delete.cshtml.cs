using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Repositories;

namespace RazorCrudSample.Pages.Product
{
    public class DeleteModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public DeleteModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public ProductDto ProductDto { get; set; } = new ProductDto();
        public async Task<IActionResult> OnGet(long? Id)
        {
            if (Id == null)
                return BadRequest();

            ProductDto = await _productRepository.GetProduct((long)Id);

            if (ProductDto == null)
                return NotFound();

            return Page();
        }


        public async Task<IActionResult> OnPost()
        {
           await _productRepository.DeleteProduct(ProductDto.Id);
            return RedirectToPage("Index");
        }

    }
}
