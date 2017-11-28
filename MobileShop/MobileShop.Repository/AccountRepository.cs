using System;
using System.Threading.Tasks;
using MobileShop.Domain.Dtos;
using MobileShop.Domain.Repositories;
using System.Net.Http;

namespace MobileShop.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private const string registerEndpoint = "api/Account/Register";
        private const string loginEndpoint = "api/Account/Login";
        private const string urlBase = "";
        private string fullUrl;

        public async Task<bool> Login(User user)
        {
            fullUrl = string.Format("{0}{1}", urlBase, loginEndpoint);
            var repositoryBase = new RepositoryBaseRest<User, bool>();
            return await repositoryBase.ConsumeRestService(user, fullUrl, HttpMethod.Post);
        }

        public async Task<bool> Register(Persona persona)
        {
            fullUrl = string.Format("{0}{1}", urlBase, registerEndpoint);
            var repositoryBase = new RepositoryBaseRest<Persona, bool>();
            return await repositoryBase.ConsumeRestService(persona, fullUrl, HttpMethod.Post);
        }
    }
}
