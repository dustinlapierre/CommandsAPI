using System.ComponentModel.DataAnnotations;

namespace SixMinApi.DTOs
{
    public class CommandCreateDto
    {
        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}