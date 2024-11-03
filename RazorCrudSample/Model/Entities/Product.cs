using System.ComponentModel.DataAnnotations;

namespace RazorCrudSample.Model.Entities
{
    public class Product
    {
        public long Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public int Price { get; set; }
        [Required]
        public string Description { get; set; } = null!;

    }
}
