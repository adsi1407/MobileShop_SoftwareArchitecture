using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MobileShop.Domain.Repositories
{
    public interface IRepositoryBaseRest<P, T>
    {
        Task<T> ConsumeRestService(P requestObject, string url, HttpMethod method, Dictionary<string, string> headers, double timeOutInSeconds);
    }
}
