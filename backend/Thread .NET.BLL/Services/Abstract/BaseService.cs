using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;

namespace Thread_.NET.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        private protected readonly IMapper _mapper;
        private protected readonly IDistributedCache _cache;

        public BaseService(IMapper mapper, IDistributedCache cache)
        {
            _mapper = mapper;
            _cache = cache;
        }
    }
}
