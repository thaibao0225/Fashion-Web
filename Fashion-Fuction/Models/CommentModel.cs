using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Models
{
    public class CommentModel
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateOn { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
    }
}
