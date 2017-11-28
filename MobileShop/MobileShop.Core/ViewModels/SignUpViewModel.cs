using MobileShop.Domain.Dtos;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace MobileShop.Core.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        #region Private Vars

        private string greeting;
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
        private string btnSigupText;

        #endregion

        #region Construction

        public SignUpViewModel()
        {
            ScreenTitle = "Registro";
            Greeting = "Hola, Regístrate en nuestra tienda";
            IdTypeLabel = "Seleccciona el tipo de documento";
            IdLabel = "Número de documento";
            IdHint = "Documento";
            NameLabel = "Ingresa tu nombre";
            NameHint = "Nombre";
            PhoneLabel = "Ingresa el número de teléfono";
            PhoneHint = "Teléfono";
            EmailLabel = "Ingresa tu email";
            EmailHint = "Email";
            BtnSigupText = "Terminar";

            IdTypes = new List<TipoIdentificacion>
            {
                new TipoIdentificacion { Id = "CC", Nombre = "Cédula de ciudadanía" },
                new TipoIdentificacion { Id = "CE", Nombre = "Cédula de extranjería" }
            };
        }

        #endregion

        #region Properties

        public string Greeting
        {
            get { return greeting; }
            set
            {
                greeting = value;
                RaisePropertyChanged(() => Greeting);
            }
        }

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
            throw new NotImplementedException();
        }

        #endregion
    }
}
