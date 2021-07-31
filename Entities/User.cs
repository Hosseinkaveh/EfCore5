using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool DeleteFlag { get; set; }
        public Image Image { get; set; }
        public ICollection<Comment> comments { get; set; }

    }
}
