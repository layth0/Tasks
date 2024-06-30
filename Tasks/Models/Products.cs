using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }
        public String Category { get; set; }



    }
}
