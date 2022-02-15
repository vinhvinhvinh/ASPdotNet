using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Account
    {
        [Key]
        [DisplayName("Mã tài khoản")]
        public int Id { get; set; }

       
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "{0} có ít nhất 8 kí tự, có một ký tự thường, một chữ số và một ký tự đặc biệt!")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        
        [RegularExpression(@"(\W|^)[\w.+\-]*@gmail\.com(\W|$)", ErrorMessage = "{0} phải có gmail")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Tên đầy đủ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} từ 6-100 kí tự")]
        public string FullName { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        
        public string Address1 { get; set; }

        [DisplayName("Địa chỉ 2")]
        
        public string Address2 { get; set; }

        
        
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

       
        [DisplayName("Tên ảnh đại diện")]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Quyền quản trị viên")]
        public bool IsAdmin { get; set; }

        [DisplayName("Trạng thái tài khoản")]
        public int Status { get; set; }

        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
