namespace Blog.Core.Features.ApprovePendingPost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Blog.Core.Domain;
    using MediatR;

    public class PendingPostApprovalRequest : IRequest<PendingPostApprovalResponse>
    {
        public int PostId { get; set; }
        public int State { get; set; }

        public PendingPostApprovalRequest(int postId, int state)
        {
            PostId = postId;
            State = state;
        }
    }
}
