using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodStore.Models
{
    [Table(name: "Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Display(Name ="Select User Name")]

        public int UserId { get; set; }

        [ForeignKey(nameof(Order.UserId))]

        public User User { get; set; }



        [Display(Name = "Select Food")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(Order.ProductId))]
        public Product Product { get; set; }

        [Required]
        [Display(Name = "Select Quantity")]
        
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Enter Your Mobile Number")]
        public string MoibileNumber { get; set; }



        [Required]
        [Display(Name = "Enter Delevery Address")]
        public string UserAddress { get; set; }

      






    }
}

