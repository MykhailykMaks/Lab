using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_5
{
    public partial class LoginWindow : Window
    {
        private AuthViewModel _viewModel;

        public LoginWindow(AuthViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            this.DataContext = _viewModel;
            _viewModel.RegisterWindowRequested += OnRegisterWindowRequested;
            _viewModel.GoogleAuthRequested += OnGoogleAuthRequested;
            _viewModel.FacebookAuthRequested += OnFacebookAuthRequested;
        }

        private void OnRegisterWindowRequested(object sender, EventArgs e)
        {
            MainWindow registerWindow = new MainWindow(_viewModel);
            registerWindow.Show();
            this.Close();
        }

        private void OnGoogleAuthRequested(object sender, EventArgs e)
        {
            GoogleAuthWindow googleWindow = new GoogleAuthWindow(_viewModel);
            googleWindow.ShowDialog();
        }

        private void OnFacebookAuthRequested(object sender, EventArgs e)
        {
            FacebookAuthWindow facebookWindow = new FacebookAuthWindow(_viewModel);
            facebookWindow.ShowDialog();
        }
        private void LoginPasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                if (_viewModel.Password != ((PasswordBox)sender).Password)
                {
                    _viewModel.Password = ((PasswordBox)sender).Password;
                }
            }
        }

        private void LoginVisiblePassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginPasswordInput.Password != ((TextBox)sender).Text)
            {
                LoginPasswordInput.Password = ((TextBox)sender).Text;
            }
        }
    }
}