using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Product
    {
        [Key]

        public int ProductId { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Đơn giá")]
        public double ProductPrice { get; set; }

        [DisplayName("Hình ảnh")]
        [DataType(DataType.ImageUrl)]
        public string ProductImage { get; set; }

        [DisplayName("Mã loại")]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Giảm giá")]
        public double Discount { get; set; }
        //public int CommentId { get; set; }

        [DisplayName("Trạng thái")]
        public bool ProductStatus { get; set; }
        public List<MenuDetail> MenuDetails { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
