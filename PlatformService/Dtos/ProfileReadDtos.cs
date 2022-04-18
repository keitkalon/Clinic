using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class ProfileReadDtos
    {
        
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
       
    }
}
