using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStore.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [DefaultValue(false)]
        public short NumberOfProducts { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Select Food Category")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Product.CategoryId))]

        public Category Category { get; set; }







    }
}