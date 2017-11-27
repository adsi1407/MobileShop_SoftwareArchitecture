using MvvmCross.Core.ViewModels;

namespace MobileShop.Core.ViewModels
{
    public class ViewModelBase: MvxViewModel
    {
        private string screenTitle;
        private string errorMessage;
        private bool showErrorMessage;

        public string ScreenTitle
        {
            get { return screenTitle; }
            set
            {
                screenTitle = value;
                RaisePropertyChanged(() => ScreenTitle);
            }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                RaisePropertyChanged(() => ErrorMessage);
            }
        }

        public bool ShowErrorMessage
        {
            get { return showErrorMessage; }
            set
            {
                showErrorMessage = value;
                RaisePropertyChanged(() => ShowErrorMessage);
            }
        }
    }
}
