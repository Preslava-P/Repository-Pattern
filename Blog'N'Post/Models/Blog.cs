using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_N_Post.Models
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public ICollection<Post> Post { get; set; }
    }
}
