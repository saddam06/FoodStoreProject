using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStore.Models
{
    [Table(name: "Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]

        public string UserFirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserLastName { get; set; }

        public ICollection<Order> Orders { get; set; }



       
    }
}