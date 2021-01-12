using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;
using Thread_.NET.DAL.Repositories.Abstract;

namespace Thread_.NET.DAL.Repositories
{
    public sealed class PostRepository : BaseRepository, IPostRepository
    {
        public PostRepository(ThreadContext context) : base(context) { }

        public async Task<ICollection<Post>> GetPosts(int threadSize, int threadPage, bool isOnlyMine, int userId)
        {
            IQueryable<Post> query = _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                        .ThenInclude(user => user.Avatar)
                .Include(post => post.NegativeReactions)
                    .ThenInclude(negativeReaction => negativeReaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                        .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.NegativeReactions)
                        .ThenInclude(negativeReaction => negativeReaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author);


            if (isOnlyMine)
            {
                query = query.Where(post => post.AuthorId == userId);
            }
        
            var posts = await query.OrderByDescending(post => post.CreatedAt)
                .Skip((threadPage - 1) * threadSize)
                .Take(threadSize)
                .ToListAsync();

            return posts;
        }

        public Task<ICollection<Post>> GetAllPosts(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Post> GetPostById(int postId)
        {
            throw new System.NotImplementedException();
        }
        
        public Task<Post> CreatePost(Post post)
        {
            throw new System.NotImplementedException();
        }
        public Task<int> UpdatePost(Post post)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeletePost(int postId)
        {
            throw new System.NotImplementedException();
        }      
    }
}
