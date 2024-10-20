using System.ComponentModel.DataAnnotations;

namespace APIConEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string phone { get; set; }
    }
}
