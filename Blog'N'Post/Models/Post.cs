using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_N_Post.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }
        public int PostNum { get; set; }
        public Blog Blog { get; set; }
    }
}
