using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Menu
    {
        [Key]
        [DisplayName("Mã Thực đơn")]
        public int MenuId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Thực đơn của ngày")]
        public DateTime MenuDate { get; set; }

      
        [DisplayName("Trạng thái")]
        public bool MenuStatus { get; set; }
        public List<MenuDetail> MenuDetails { get; set; }
    }
}
