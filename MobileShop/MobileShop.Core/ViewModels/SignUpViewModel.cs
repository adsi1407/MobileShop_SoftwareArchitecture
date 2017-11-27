using MobileShop.Domain.Dtos;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace MobileShop.Core.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        #region Private Vars

        private string idTypeLabel;
        private List<TipoIdentificacion> idTypes;
        private TipoIdentificacion selectedIdType;
        private string idLabel;
        private string idHint;
        private string idText;
        private string nameLabel;
        private string nameHint;
        private string nameText;
        private string phoneLabel;
        private string phoneHint;
        private string phoneText;
        private string emailLabel;
        private string emailHint;
        private string emailText;
        private string userTypeLabel;
        private string userTypeClientText;
        private string userTypeSellerText;
        private int selectedUserType;
        private string btnSigupText;

        #endregion

        #region Properties

        public string IdTypeLabel
        {
            get { return idTypeLabel; }
            set
            {
                idTypeLabel = value;
                RaisePropertyChanged(() => IdTypeLabel);
            }
        }

        public List<TipoIdentificacion> IdTypes
        {
            get { return idTypes; }
            set
            {
                idTypes = value;
                RaisePropertyChanged(() => IdTypes);
            }
        }

        public TipoIdentificacion SelectedIdType
        {
            get { return selectedIdType; }
            set
            {
                selectedIdType = value;
                RaisePropertyChanged(() => SelectedIdType);
            }
        }

        public string IdLabel
        {
            get { return idLabel; }
            set
            {
                idLabel = value;
                RaisePropertyChanged(() => IdLabel);
            }
        }
        public string IdHint
        {
            get { return idHint; }
            set
            {
                idHint = value;
                RaisePropertyChanged(() => IdHint);
            }
        }

        public string IdText
        {
            get { return idText; }
            set
            {
                idText = value;
                RaisePropertyChanged(() => IdText);
            }
        }

        public string NameLabel
        {
            get { return nameLabel; }
            set
            {
                nameLabel = value;
                RaisePropertyChanged(() => NameLabel);
            }
        }

        public string NameHint
        {
            get { return nameHint; }
            set
            {
                nameHint = value;
                RaisePropertyChanged(() => NameHint);
            }
        }

        public string NameText
        {
            get { return nameText; }
            set
            {
                nameText = value;
                RaisePropertyChanged(() => NameText);
            }
        }
        public string PhoneLabel
        {
            get { return phoneLabel; }
            set
            {
                phoneLabel = value;
                RaisePropertyChanged(() => PhoneLabel);
            }
        }

        public string PhoneHint
        {
            get { return phoneHint; }
            set
            {
                phoneHint = value;
                RaisePropertyChanged(() => PhoneHint);
            }
        }

        public string PhoneText
        {
            get { return phoneText; }
            set
            {
                phoneText = value;
                RaisePropertyChanged(() => PhoneText);
            }
        }

        public string EmailLabel
        {
            get { return emailLabel; }
            set
            {
                emailLabel = value;
                RaisePropertyChanged(() => EmailLabel);
            }
        }

        public string EmailHint
        {
            get { return emailHint; }
            set
            {
                emailHint = value;
                RaisePropertyChanged(() => EmailHint);
            }
        }
        public string EmailText
        {
            get { return emailText; }
            set
            {
                emailText = value;
                RaisePropertyChanged(() => EmailText);
            }
        }

        public string UserTypeLabel
        {
            get { return userTypeLabel; }
            set
            {
                userTypeLabel = value;
                RaisePropertyChanged(() => UserTypeLabel);
            }
        }

        public string UserTypeClientText
        {
            get { return userTypeClientText; }
            set
            {
                userTypeClientText = value;
                RaisePropertyChanged(() => UserTypeClientText);
            }
        }

        public string UserTypeSellerText
        {
            get { return userTypeSellerText; }
            set
            {
                userTypeSellerText = value;
                RaisePropertyChanged(() => UserTypeSellerText);
            }
        }

        public int SelectedUserType
        {
            get { return selectedUserType; }
            set
            {
                selectedUserType = value;
                RaisePropertyChanged(() => SelectedUserType);
            }
        }
        public string BtnSigupText
        {
            get { return btnSigupText; }
            set
            {
                btnSigupText = value;
                RaisePropertyChanged(() => BtnSigupText);
            }
        }


        #endregion

        #region Commands

        public ICommand SignUpCommand
        {
            get
            {
                return new MvxCommand(() => SignupUserCommand());
            }
        }

        #endregion

        #region Class Methods

        private void SignupUserCommand()
        {
        }

        #endregion
    }
}
