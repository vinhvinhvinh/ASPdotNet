using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        //public int CommentId { get; set; }
        public bool ProductStatus { get; set; }
    }
}
