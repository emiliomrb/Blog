namespace Blog.Core.Features.ApprovePendingPost
{
    using Blog.Core.Dto;

    public class PendingPostApprovalResponse
    {
        public PostModel Post { get; set; }
        public PendingPostApprovalResponse(PostModel post)
        {
            Post = post;
        }
    }
}
