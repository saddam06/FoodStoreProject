using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStore.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Enter Food Category")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

       




    }
}