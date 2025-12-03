using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab_5
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
        public void Execute(object parameter) => _execute(parameter);
    }
    public class AuthViewModel : INotifyPropertyChanged
    {
        private readonly UserManager _userManager = new UserManager();

        private string _username;
        private string _email;
        private string _password;
        private int _age;
        private string _gender;
        private string _message;

        private bool _isPasswordVisible;
        public bool IsPasswordVisible
        {
            get => _isPasswordVisible;
            set
            {
                _isPasswordVisible = value;
                OnPropertyChanged(nameof(IsPasswordVisible));
                OnPropertyChanged(nameof(PasswordVisibility));
                OnPropertyChanged(nameof(TextBoxVisibility));
            }
        }

        public Visibility PasswordVisibility => IsPasswordVisible ? Visibility.Collapsed : Visibility.Visible;
        public Visibility TextBoxVisibility => IsPasswordVisible ? Visibility.Visible : Visibility.Collapsed;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public int Age
        {
            get => _age;
            set { _age = value; OnPropertyChanged(nameof(Age)); }
        }

        public string Gender
        {
            get => _gender;
            set { _gender = value; OnPropertyChanged(nameof(Gender)); }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public string Message
        {
            get => _message;
            private set { _message = value; OnPropertyChanged(nameof(Message)); }
        }


        public event EventHandler LoginWindowRequested;
        public event EventHandler RegisterWindowRequested;
        public event EventHandler GoogleAuthRequested;
        public event EventHandler FacebookAuthRequested;


        public ICommand RegisterCommand { get; }
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegisterCommand { get; }
        public ICommand PerformLoginCommand { get; }
        public ICommand GoogleLoginCommand { get; }
        public ICommand FacebookLoginCommand { get; }
        public ICommand TogglePasswordCommand { get; }

        public AuthViewModel()
        {
            RegisterCommand = new RelayCommand(ExecuteRegister, CanExecuteRegister);


            NavigateToLoginCommand = new RelayCommand(p => LoginWindowRequested?.Invoke(this, EventArgs.Empty));
            NavigateToRegisterCommand = new RelayCommand(p => RegisterWindowRequested?.Invoke(this, EventArgs.Empty));


            PerformLoginCommand = new RelayCommand(ExecuteLogin);

            GoogleLoginCommand = new RelayCommand(p => GoogleAuthRequested?.Invoke(this, EventArgs.Empty));
            FacebookLoginCommand = new RelayCommand(p => FacebookAuthRequested?.Invoke(this, EventArgs.Empty));


            TogglePasswordCommand = new RelayCommand(p => IsPasswordVisible = !IsPasswordVisible);
        }

        private bool CanExecuteRegister(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) &&
                   IsValidEmail(Email) &&
                   !string.IsNullOrWhiteSpace(Password) &&
                   Age > 0 &&
                   !string.IsNullOrWhiteSpace(Gender);
        }

        private void ExecuteRegister(object parameter)
        {
            if (!IsValidEmail(Email))
            {
                Message = "Invalid email format!";
                return;
            }

            if (_userManager.Users.ContainsKey(Username.ToLower()))
            {
                Message = "Username already exists!";
                return;
            }
            if (Age < 6 || Age > 120)
            {
                Message = "Unrealistic age!";
                return;
            }
            string salt = UserManager.GenerateSalt();
            string hashedPassword = UserManager.HashPassword(Password, salt);

            var newUser = new User(Username, hashedPassword, Email, Age, Gender)
            {
                Salt = salt
            };

            _userManager.AddUser(newUser);
            _userManager.SaveUsersToFileJson();
            Message = "Registration successful! You can sign in.";
        }

        private void ExecuteLogin(object parameter)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                Message = "Enter username and password!";
                return;
            }

            bool isAuthenticated = _userManager.CheckCredentials(Username, Password);

            if (isAuthenticated)
            {
                Message = $"Welcome, {Username}!";
                MessageBox.Show("Login Successful!", "Success");
            }
            else
            {
                Message = "Invalid username or password!";
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
            catch
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}