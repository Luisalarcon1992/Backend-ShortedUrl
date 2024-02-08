using System.ComponentModel.DataAnnotations;

namespace Backend_ShortedUrl.Models.DTO
{
    public class URLDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        [MinLength(5)]        
        public required string Url { get; set; }
        public string? Title { get; set; }
    }
}
