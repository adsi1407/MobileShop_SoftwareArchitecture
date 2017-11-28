using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MobileShop.Core.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        #region Private Vars

        private string lblLoginHint;
        private string txtLoginText;
        private string txtLoginHint;
        private string lblKeyHint;
        private string txtPasswordText;
        private string txtKeyHint;
        private string btnLoginText;
        private string lblForgotKey;
        private string lblSignUp;

        #endregion

        #region Construction

        public LoginViewModel()
        {
            ScreenTitle = "Login";
            LblLoginHint = "Ingresa tu usuario";
            TxtLoginHint = "Email";
            LblKeyHint = "Ingresa tu clave";
            TxtKeyHint = "Clave";
            BtnLoginText = "Entrar";
            LblForgotKey = "¡Olvidé mi clave!";
            LblSignUp = "Registrarme";
        }

        #endregion

        #region Properties

        public string LblLoginHint
        {
            get { return lblLoginHint; }
            set
            {
                lblLoginHint = value;
                RaisePropertyChanged(() => LblLoginHint);
            }
        }

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

        public string LblKeyHint
        {
            get { return lblKeyHint; }
            set
            {
                lblKeyHint = value;
                RaisePropertyChanged(() => LblKeyHint);
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

        public string TxtKeyHint
        {
            get { return txtKeyHint; }
            set
            {
                txtKeyHint = value;
                RaisePropertyChanged(() => TxtKeyHint);
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

        public string LblForgotKey
        {
            get { return lblForgotKey; }
            set
            {
                lblForgotKey = value;
                RaisePropertyChanged(() => LblForgotKey);
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

        public ICommand SignupCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SignUpViewModel>());
            }
        }

        #endregion
    }
}
