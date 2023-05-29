namespace Blog.Core.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Blog.Core.Domain;

    public class PostModel
    {
        public int Id { get; set; }
        public DateTime SubmitDate { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public PostState State { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
    }
}
