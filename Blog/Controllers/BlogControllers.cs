namespace Blog.Controllers
{
    using Blog.Core.Dto;
    using Blog.Core.Features.ApprovePendingPost;
    using Blog.Core.Features.GetPendingPosts;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("blog/editors")]
    public class BlogControllers : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogControllers(IMediator mediator) => _mediator = mediator;
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetAllPendingPosts()
        {
            var request = new GetPendingPostsRequest();
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("/approval/{postId}/{state}")]
        public async Task<ActionResult<PostModel>> PendingPostApproval(int postId, int state)
        {
            var request = new PendingPostApprovalRequest(postId, state);
            var response = await _mediator.Send(request);
            return Ok(response);
        }           
    }
}
