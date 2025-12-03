using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab_5
{
    public partial class MainWindow : Window
    {
        private AuthViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new AuthViewModel();
            SetupWindow();
        }
        public MainWindow(AuthViewModel existingViewModel)
        {
            InitializeComponent();
            _viewModel = existingViewModel;
            SetupWindow();
        }
        private void SetupWindow()
        {
            this.DataContext = _viewModel;
            _viewModel.LoginWindowRequested += OnLoginWindowRequested;
            _viewModel.GoogleAuthRequested += OnGoogleAuthRequested;
            _viewModel.FacebookAuthRequested += OnFacebookAuthRequested;
        }

        private void OnLoginWindowRequested(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(_viewModel);
            loginWindow.Show();
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
        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                if (_viewModel.Password != ((PasswordBox)sender).Password)
                {
                    _viewModel.Password = ((PasswordBox)sender).Password;
                }
            }
        }
        private void VisiblePassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PasswordInput.Password != ((TextBox)sender).Text)
            {
                PasswordInput.Password = ((TextBox)sender).Text;
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AgeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AgeTextBox.Text == "0")
            {
                AgeTextBox.Text = "";
                AgeTextBox.Foreground = Brushes.Black;
            }
        }

        private void AgeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AgeTextBox.Text))
            {
                AgeTextBox.Text = "0";
                AgeTextBox.Foreground = Brushes.Gray;
            }
        }
    }
}