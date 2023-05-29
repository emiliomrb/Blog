namespace Blog.Core.Features.GetPendingPosts
{
    using System.Collections.Generic;
    using Blog.Core.Dto;

    public class GetPendingPostsResponse
    {
        public GetPendingPostsResponse(IEnumerable<PostDto> postDtos)
        {
            Posts = postDtos;
        }

        IEnumerable<PostDto> Posts { get;}
    }
}
