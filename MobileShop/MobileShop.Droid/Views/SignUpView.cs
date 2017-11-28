using Android.App;
using Android.OS;
using MobileShop.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MobileShop.Droid.Views
{
    [Activity]
    public class SignUpView : MvxAppCompatActivity
    {
        #region Properties

        public new SignUpViewModel ViewModel
        {
            get { return (SignUpViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        #endregion

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.signup_activity);
            Title = ViewModel.ScreenTitle;
        }
    }
}