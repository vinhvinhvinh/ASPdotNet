using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public DateTime IssueDate { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }

    }
}
