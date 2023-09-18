using System.ComponentModel.DataAnnotations;

namespace MVCUnitProject.Models
{
    public class JordanModel
    {
        // Require name entry
        [Required]
        public string? name { get; set; }
    }
}
