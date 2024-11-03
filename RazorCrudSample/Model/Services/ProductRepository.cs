using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RazorCrudSample.Model.Context;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Entities;
using RazorCrudSample.Model.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace RazorCrudSample.Model.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _maper;

        public ProductRepository(DatabaseContext context,IMapper maper)
        {
            _context = context;
            _maper = maper;
        }
        public async Task<List<ProductDto>> GetProducts()
        {
            var productModel = await _context.Products.AsNoTracking().ToListAsync();
            var products = _maper.Map<List<ProductDto>>(productModel);
            return products;
        }

        public async Task<ProductDto> GetProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);
            var productModel = _maper.Map<ProductDto>(product);
            return productModel;
        }
 
        public async Task<bool> CreateProduct(ProductCreationDto model)
        {
            try
            {
                var productModel = _maper.Map<Product>(model);
                await _context.Products.AddAsync(productModel);
                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(long id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product==null)
                    return false;

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;

            }
        }

        public async Task<bool> UpdateProduct(ProductDto model)
        {
            try
            {
                var productModel = _maper.Map<Product>(model);
                _context.Products.Update(productModel);
                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
