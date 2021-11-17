using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Account
    {
        [Key]
        [DisplayName("Mã tài khoản")]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "{0} có ít nhất 8 kí tự, có một ký tự thường, một chữ số và một ký tự đặc biệt!")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "{0} không hợp lệ!")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}", ErrorMessage = "{0} không hợp lệ!")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Email { get; set; }

        [DisplayName("Tên đầy đủ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} từ 6-100 kí tự")]
        public string FullName { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Text)]
        public string Address1 { get; set; }

        [DisplayName("Địa chỉ 2")]
        [DataType(DataType.Text)]
        public string Address2 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"0\d{9}", ErrorMessage = "{0} không hợp lệ!")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Đường dẫn ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Quyền quản trị viên")]
        public bool IsAdmin { get; set; }

        [DisplayName("Trạng thái tài khoản")]
        public int Status { get; set; }

        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
