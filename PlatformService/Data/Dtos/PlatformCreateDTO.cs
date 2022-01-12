using System.ComponentModel.DataAnnotations;

namespace PlatformService.Data.DTOs
{
    public class PlatformCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}
