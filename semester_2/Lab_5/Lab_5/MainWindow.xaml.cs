using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AuthViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new AuthViewModel();
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