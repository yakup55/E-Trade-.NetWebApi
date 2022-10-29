using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CommentDto
    {
        public string CommentName { get; set; }
        public string Message { get; set; }
        public int ProductCommentsId { get; set; }
    }
}
