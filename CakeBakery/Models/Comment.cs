using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Comment
    {
        [Key]

        [DisplayName("Mã bình luận")]
        public int Id { get; set; }

        [DisplayName("Mã khách hàng")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Mã nội dung")]
        [DataType(DataType.Text)]
        public string Content { get; set; }

        [DisplayName("Thời gian")]
        [DataType(DataType.DateTime)]
        public DateTime PostedDate { get; set; }

        [DisplayName("Trạng thái")]
        public int Status { get; set; }

    }
}
