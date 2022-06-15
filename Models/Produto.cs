using System.ComponentModel.DataAnnotations;

namespace TechItems.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
