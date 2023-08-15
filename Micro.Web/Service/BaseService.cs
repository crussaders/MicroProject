using Micro.Web.Models;
using Micro.Web.Service.IService;

namespace Micro.Web.Service
{
    public class BaseService : IBaseService
    {
        public Task<ResponseDto> SendAsync(RequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
