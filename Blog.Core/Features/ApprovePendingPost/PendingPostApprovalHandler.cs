namespace Blog.Core.Features.ApprovePendingPost
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Ardalis.GuardClauses;
    using Blog.Core.Contracts;
    using Blog.Core.Domain;
    using Blog.Core.Mapping;
    using MediatR;

    public class PendingPostApprovalHandler : IRequestHandler<PendingPostApprovalRequest, PendingPostApprovalResponse>
    {
        private readonly IPostRepository _repository;

        public PendingPostApprovalHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<PendingPostApprovalResponse> Handle(PendingPostApprovalRequest request, CancellationToken cancellationToken)
        {
            Validate(request);

            var post = _repository.GetPostById(request.PostId);
            Guard.Against.Null(post, nameof(post), $"Post not found for ID: {request.PostId}");

            switch ((PostState)request.State)
            {
                case PostState.Aproved:
                    post.State = PostState.Aproved;
                    break;

                case PostState.Rejected:
                    post.State = PostState.Aproved;
                    break;
            }

            _repository.SaveChanges();

            return new PendingPostApprovalResponse(post.ToPostModel());
        }

        private void Validate(PendingPostApprovalRequest request)
        {
            Guard.Against.Null(request, nameof(request));
            Guard.Against.Null(request.PostId, "Post id cannot be null");
            Guard.Against.Negative(request.PostId, nameof(request.PostId));
            Guard.Against.Null(request.State, nameof(request.State));
            Guard.Against.EnumOutOfRange((PostState)request.State, nameof(request.State));
        }
    }
}
