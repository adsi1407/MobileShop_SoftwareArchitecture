using MobileShop.Core.ViewModels;
using MobileShop.Domain.Repositories;
using MobileShop.Repository;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MobileShop.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            Mvx.ConstructAndRegisterSingleton<IAccountRepository, AccountRepository>();

            RegisterNavigationServiceAppStart<LoginViewModel>();
        }
    }
}
