using System.Collections.Generic;

namespace ExemploBasicoEntity.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public virtual List<Post> Post { get; set; }
    }
}
