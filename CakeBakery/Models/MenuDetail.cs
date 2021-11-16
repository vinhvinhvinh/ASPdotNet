using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class MenuDetail
    {
        [Key]
        [DisplayName("Mã chi tiết thực đơn")]
        public int MenuDetailId { get; set; }

        [DisplayName("Mã Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Stock { get; set; }

        [DisplayName("Đã hết")]
        public bool IsSoldOut { get; set; }
    }
}
