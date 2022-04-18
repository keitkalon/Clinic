

using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Profile
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Identification { get; set; }
    }

}