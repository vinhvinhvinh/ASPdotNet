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
        [DisplayName("Mã CT Thực đơn")]
        public int Id { get; set; }

        [DisplayName("Mã Thực đơn")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Còn lại")]
        public int Stock { get; set; }
    }
}
