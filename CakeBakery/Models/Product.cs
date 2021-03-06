using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CakeBakery.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Đơn giá")]
        public int Price { get; set; }

        [DisplayName("Hình ảnh")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Mã loại")]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Giảm giá")]
        public int Discount { get; set; }
        //public int CommentId { get; set; }

        [DisplayName("Còn hiệu lực")]
        public int Status { get; set; }
      
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<MenuDetail> MenuDetails { get; set; }



    }
}
