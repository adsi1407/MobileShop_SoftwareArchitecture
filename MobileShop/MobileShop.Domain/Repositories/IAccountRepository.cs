using MobileShop.Domain.Dtos;
using System.Threading.Tasks;

namespace MobileShop.Domain.Repositories
{
    public interface IAccountRepository
    {
        Task<bool> Register(Persona persona);

        Task<bool> Login(User user);
    }
}
