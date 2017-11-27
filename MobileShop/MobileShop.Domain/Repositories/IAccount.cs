using MobileShop.Domain.Dtos;
using System.Threading.Tasks;

namespace MobileShop.Domain.Repositories
{
    public interface IAccount
    {
        Task<bool> RegisterClient(Cliente cliente);

        Task<bool> RegisterSeller(Vendedor vendedor);

        Task<bool> Login(User user);
    }
}
