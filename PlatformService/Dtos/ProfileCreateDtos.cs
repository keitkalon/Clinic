using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class ProfileCreateDtos
    {                
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Identification { get; set; }
    }
}
