using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Order
    {
        [Key]

        [DisplayName("Mã hóa đơn")]
        public int Id { get; set; }

        [DisplayName("Mã khách hàng")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Ngày lập hoá đơn")]
        [DataType(DataType.Date, ErrorMessage = "{0} không hợp lệ!")]
        public DateTime IssueDate { get; set; }

        [DisplayName("Nơi giao hàng")]
        public string ShippingAddress { get; set; }

        [DisplayName("Tổng hoá đơn")]
        //[DataType(DataType.Currency)]
        public int Total { get; set; }

        [DisplayName("Trạng thái")]
        public int Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
