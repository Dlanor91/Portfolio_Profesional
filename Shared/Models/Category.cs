using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Category
    {
        [Key] /*esto define que es la clave de mi sistema de BD*/
        public int CategoryID { get; set; } 

        [Required] /*significa que es un campo requerido de mi BD not null y su tamanno respecto a la BD*/
        [MaxLength(256)]
        public string ThumbnailImagePath { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

    }
}
