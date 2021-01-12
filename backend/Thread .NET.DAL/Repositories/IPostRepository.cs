using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Repositories
{
    public interface IPostRepository
    {
        Task<ICollection<Post>> GetPosts(int threadSize, int threadPage, bool isOnlyMine, int userId);
        Task<ICollection<Post>> GetAllPosts(int userId);
        Task<Post> GetPostById(int postId);
        Task<Post> CreatePost(Post post);
        Task<int> UpdatePost(Post post);
        Task<bool> DeletePost(int postId);
    }
}
