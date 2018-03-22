using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SampleApp.Models;
using SampleApp.Services;
using Xamarin.Forms;

namespace SampleApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private AuthenticationService _authenticationService;

        public LoginPageViewModel()
        {
            _authenticationService = new AuthenticationService();
            LoginCommand = new Command(Login);
        }

        public ICommand LoginCommand { get; }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void Login()
        {
            //WE CREATE A MODEL AND A SERVICE
            var getValues = $"{Username} {Password}";
            var authModel = new DtoAuthModel
            {
                Password = Password,
                UserName = Username
            };

            //faking a call to webservice
            var authenticated = _authenticationService.AuthenticateUserPassword(authModel);

            if (authenticated)
            {
                //navigate to page wherever you want
                App.Current.MainPage.Navigation.PushAsync(new DataEntryPage());
            }

            Console.WriteLine(getValues);
        }
    }
}
