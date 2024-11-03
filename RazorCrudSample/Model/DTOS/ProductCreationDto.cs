namespace RazorCrudSample.Model.DTOS
{
    public class ProductCreationDto
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
    }
}