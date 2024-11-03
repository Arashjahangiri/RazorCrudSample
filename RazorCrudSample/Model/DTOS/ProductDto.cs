﻿namespace RazorCrudSample.Model.DTOS
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
    }
}
