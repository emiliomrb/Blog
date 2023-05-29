namespace Blog.Core.Dto
{
    using System;  

    public class PostDto
    {
        public int Id { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Title { get; set; }
        public string Corpus { get; set; }
    }
}
