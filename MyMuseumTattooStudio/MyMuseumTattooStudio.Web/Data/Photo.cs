using System.ComponentModel.DataAnnotations;

namespace MyMuseumTattooStudio.Web.Models
{
    public class Photo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int PhotoCategoryId { get; set; }

        public string UserId { get; set; }

        [Required]
        public byte[] Data { get; set; }

        public virtual PhotoCategory PhotoCategory { get; set; }
    }
}
