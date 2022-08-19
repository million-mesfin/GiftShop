using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string ItemName { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public string AvailabilityStatus { get; set; }
        public string Description { get; set; }

        //Relationships
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
