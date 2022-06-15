using System.ComponentModel.DataAnnotations;

namespace TechItems.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
