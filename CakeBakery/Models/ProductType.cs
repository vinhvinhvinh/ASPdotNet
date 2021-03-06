using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên loại sản phẩm")]
        public string TypeName { get; set; }

        [DisplayName("Trạng thái")]
        public int Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
//