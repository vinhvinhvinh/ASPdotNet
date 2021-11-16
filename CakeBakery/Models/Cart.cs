using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Cart
    {
        [Key]
        [DisplayName("Mã giỏ hàng")]
        public int CartId { get; set; }

        [DisplayName("Mã khách hàng")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        

    }
}
