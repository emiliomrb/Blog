﻿namespace Blog.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Blog.Core.Domain;

    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPendingPosts();
    }
}
