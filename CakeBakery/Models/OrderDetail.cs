using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class OrderDetail
    {
        [Key]

        [DisplayName("Mã chi tiết hóa đơn")]
        public int OrderDetailId { get; set; }

        [DisplayName("Mã hóa đơn")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [DisplayName("Giá")]
        public double Price { get; set; }

        [DisplayName("Tổng hóa đơn")]
        public int Total { get; set; }
    }
}
