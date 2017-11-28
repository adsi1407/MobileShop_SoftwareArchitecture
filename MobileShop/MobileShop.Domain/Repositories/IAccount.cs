using MobileShop.Domain.Dtos;
using System.Threading.Tasks;

namespace MobileShop.Domain.Repositories
{
    public interface IAccount
    {
        Task<bool> Register(Persona persona);

        Task<bool> Login(User user);
    }
}
