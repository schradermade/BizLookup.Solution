using System.ComponentModel.DataAnnotations;

namespace BizLookupApi.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength (40)]
        public string Industry { get; set; }
        [Required]
        // [Range(0, 200, ErrorMessage = "Industry must be between 0 and 200.")]
        public string Address { get; set; }
        [Required]
        public string Hours { get; set; }
    }
}