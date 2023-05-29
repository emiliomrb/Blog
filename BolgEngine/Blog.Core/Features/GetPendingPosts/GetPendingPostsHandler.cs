﻿namespace Blog.Core.Features.GetPendingPosts
{
    using System.Threading;
    using System.Threading.Tasks;
    using Blog.Core.Contracts;
    using Blog.Core.Mapping;
    using MediatR;

    public class GetPendingPostsHandler : IRequestHandler<GetPendingPostsRequest, GetPendingPostsResponse>
    {
        private readonly IPostRepository _repository;
        public GetPendingPostsHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public GetPendingPostsResponse Handle (GetPendingPostsRequest request)
        {
            var pendingPosts = _repository.GetAllPendingPosts();
            return new GetPendingPostsResponse(pendingPosts.ToModel());
        }

        public Task<GetPendingPostsResponse> Handle(GetPendingPostsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
