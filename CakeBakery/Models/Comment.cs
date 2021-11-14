using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeBakery.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
