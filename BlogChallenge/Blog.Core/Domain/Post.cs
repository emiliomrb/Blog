namespace Blog.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Post
    {
        public int Id { get; set; }
        public DateTime SubmitDate { get; set; }
        public Writer Author { get; set; }
        public PostState State { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }

    }
}
