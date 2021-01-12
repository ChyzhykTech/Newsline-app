using Thread_.NET.DAL.Context;

namespace Thread_.NET.DAL.Repositories.Abstract
{
    public abstract class BaseRepository
    {
        private protected readonly ThreadContext _context;

        public BaseRepository(ThreadContext context)
        {
            _context = context;
        }
    }
}
