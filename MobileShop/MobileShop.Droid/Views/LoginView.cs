using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MobileShop.Droid.Views
{
    [Activity(MainLauncher = true)]
    public class LoginView : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.login_activity);
        }
    }
}