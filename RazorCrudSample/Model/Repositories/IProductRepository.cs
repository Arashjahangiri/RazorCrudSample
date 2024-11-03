using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Entities;

namespace RazorCrudSample.Model.Repositories
{
    public interface IProductRepository
    {
        public Task<List<ProductDto>> GetProducts();
        public Task<ProductDto> GetProduct(long id);
        public Task<bool> CreateProduct(ProductCreationDto model);
        public Task<bool> UpdateProduct(ProductDto model);
        public Task<bool> DeleteProduct(long id);
    }
}
