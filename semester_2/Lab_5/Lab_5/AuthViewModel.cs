using System;
using System.ComponentModel;
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
        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        public string Gender
        {
            get => _gender;
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    OnPropertyChanged(nameof(Gender));
                    CommandManager.InvalidateRequerySuggested();
                }
            }
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
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        public string Message { get; private set; }
        private void SetMessage(string value)
        {
            Message = value;
            OnPropertyChanged(nameof(Message));
        }

        public event EventHandler LoginWindowRequested;
        public event EventHandler GoogleAuthRequested;
        public event EventHandler FacebookAuthRequested;
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        public ICommand GoogleLoginCommand { get; }
        public ICommand FacebookLoginCommand { get; }
        public AuthViewModel()
        {
            RegisterCommand = new RelayCommand(ExecuteRegister, CanExecuteRegister);
            LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
            GoogleLoginCommand = new RelayCommand(p => GoogleAuthRequested?.Invoke(this, EventArgs.Empty));
            FacebookLoginCommand = new RelayCommand(p => FacebookAuthRequested?.Invoke(this, EventArgs.Empty));
        }
        private bool CanExecuteRegister(object parameter)
        {
            string password = parameter as string;
            return !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(password) &&
                   Age > 0 &&
                   !string.IsNullOrWhiteSpace(Gender);
        }

        private void ExecuteRegister(object parameter)
        {
            string password = parameter as string;

            if (_userManager.Users.ContainsKey(Username.ToLower()))
            {
                SetMessage("This username already exist!");
                return;
            }
            string salt = UserManager.GenerateSalt();
            string hashedPassword = UserManager.HashPassword(password, salt);

            var newUser = new User
            {
                Username = this.Username,
                Email = this.Email,
                Age = this.Age,
                Gender = this.Gender,
                PasswordHash = hashedPassword,
                Salt = salt
            };

            _userManager.AddUser(newUser);
            _userManager.SaveUsersToFileJson();
            SetMessage("Registration successful!");
        }
        private bool CanExecuteLogin(object parameter)
        {
            return true;
        }

        private void ExecuteLogin(object parameter)
        {
            LoginWindowRequested?.Invoke(this, EventArgs.Empty);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}