using MobileShop.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace MobileShop.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<LoginViewModel>();
        }
    }
}
