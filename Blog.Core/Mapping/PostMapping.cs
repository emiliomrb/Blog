namespace Blog.Core.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Blog.Core.Domain;
    using Blog.Core.Dto;

    public static class PostMapping
    {
        public static IEnumerable<PostDto> ToModel (this IEnumerable<Post> posts)
        {
            return posts.Select(p => p.ToModel()).ToList();
        }

        public static PostDto ToModel(this Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                WriterName = post.Author.Name,
                WriterSurname = post.Author.Surname,
                SubmissionDate = post.SubmitDate
            };
        }

        public static PostModel ToPostModel(this Post post)
        {
            return new PostModel
            {
                Id = post.Id,
                SubmitDate = post.SubmitDate,
                AuthorName = post.Author.Name,
                AuthorSurname = post.Author.Surname,
                State = post.State,
                Title = post.Title,
                Article = post.Article,
            };
        }
    }
}
