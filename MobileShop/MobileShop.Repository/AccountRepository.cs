using System;
using System.Threading.Tasks;
using MobileShop.Domain.Dtos;
using MobileShop.Domain.Repositories;

namespace MobileShop.Repository
{
    public class AccountRepository : IAccount
    {
        public Task<bool> Login(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterClient(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterSeller(Vendedor vendedor)
        {
            throw new NotImplementedException();
        }
    }
}
