using System.ComponentModel.DataAnnotations;

namespace Backend_ShortedUrl.Models
{
    public class URL
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string UrlOrigin { get; set; }
        [Required]
        public required string DescriptionUrl { get; set; }
        public string? TitleUrl { get; set; }
        public DateTime dateCreated;

        public URL()
        {
            dateCreated = DateTime.Now;
        }
    }
}
