using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Category
    {

        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public sbyte Name { get; set; }
    }
}