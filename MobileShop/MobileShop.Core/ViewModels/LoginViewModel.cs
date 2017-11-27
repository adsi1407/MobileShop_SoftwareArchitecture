using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MobileShop.Core.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        #region Private Vars

        private string txtLoginText;
        private string txtLoginHint;
        private string txtPasswordText;
        private string txtPasswordHint;
        private string btnLoginText;
        private string lblForgotPassword;
        private string lblDontHaveAccount;
        private string lblSignUp;

        #endregion

        #region Properties

        public string TxtLoginText
        {
            get { return txtLoginText; }
            set
            {
                txtLoginText = value;
                RaisePropertyChanged(() => TxtLoginText);
            }
        }

        public string TxtLoginHint
        {
            get { return txtLoginHint; }
            set
            {
                txtLoginHint = value;
                RaisePropertyChanged(() => TxtLoginHint);
            }
        }

        public string TxtPasswordText
        {
            get { return txtPasswordText; }
            set
            {
                txtPasswordText = value;
                RaisePropertyChanged(() => TxtPasswordText);
            }
        }

        public string TxtPasswordHint
        {
            get { return txtPasswordHint; }
            set
            {
                txtPasswordHint = value;
                RaisePropertyChanged(() => TxtPasswordHint);
            }
        }

        public string BtnLoginText
        {
            get { return btnLoginText; }
            set
            {
                btnLoginText = value;
                RaisePropertyChanged(() => BtnLoginText);
            }
        }

        public string LblForgotPassword
        {
            get { return lblForgotPassword; }
            set
            {
                lblForgotPassword = value;
                RaisePropertyChanged(() => LblForgotPassword);
            }
        }

        public string LblDontHaveAccount
        {
            get { return lblDontHaveAccount; }
            set
            {
                lblDontHaveAccount = value;
                RaisePropertyChanged(() => LblDontHaveAccount);
            }
        }

        public string LblSignUp
        {
            get { return lblSignUp; }
            set
            {
                lblSignUp = value;
                RaisePropertyChanged(() => LblSignUp);
            }
        }

        #endregion

        #region Commands

        public ICommand SignUpCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SignUpViewModel>());
            }
        }

        #endregion
    }
}
