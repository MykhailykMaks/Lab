using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Data;
using System.Windows.Input;

namespace Lab_6
{
    public class WorkerApplicationsManager : INotifyPropertyChanged
    {
        public string filepath = "workersApps.json";

        public ICommand AddButtonCommand { get; private set; }
        public ICommand ChangeButtonCommand { get; private set; }
        public ICommand DeleteButtonCommand { get; private set; }
        public ICommand CheckButtonCommand { get; private set; }
        public ICommand FilterCommand { get; private set; }

        public ObservableCollection<WorkerApplication> Applications { get; set; }

        private WorkerApplication _currentApplication;
        public WorkerApplication currentapplication
        {
            get => _currentApplication;
            set
            {
                _currentApplication = value;
                OnPropertyChanged(nameof(currentapplication));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public WorkerApplicationsManager()
        {
            Applications = new ObservableCollection<WorkerApplication>();
            LoadUsersFromFileJson(filepath);

            AddButtonCommand = new RelayCommand(AddButton);
            ChangeButtonCommand = new RelayCommand(ChangeButton, CanChangeOrDelete);
            DeleteButtonCommand = new RelayCommand(DeleteButton, CanChangeOrDelete);
            CheckButtonCommand = new RelayCommand(CheckButton, CanChangeOrDelete);
            FilterCommand = new RelayCommand(ApplyFilter);
        }

        public void SaveUsersToFileJson(string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(Applications, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex) { System.Windows.MessageBox.Show("Error saving: " + ex.Message); }
        }

        public void LoadUsersFromFileJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    var loaded = JsonSerializer.Deserialize<ObservableCollection<WorkerApplication>>(json);
                    if (loaded != null)
                    {
                        foreach (var item in loaded) Applications.Add(item);
                    }
                }
                catch { }
            }
        }

        private void AddButton(object parameter)
        {
            AddWindow addWindow = new AddWindow();
            WorkerApplication newApp = new WorkerApplication();
            addWindow.DataContext = newApp;

            if (addWindow.ShowDialog() == true)
            {
                Applications.Add(newApp);
                SaveUsersToFileJson(filepath);
            }
        }

        private bool CanChangeOrDelete(object parameter)
        {
            return currentapplication != null;
        }

        private void ChangeButton(object parameter)
        {
            AddWindow changeWindow = new AddWindow();
            changeWindow.DataContext = currentapplication;

            if (changeWindow.ShowDialog() == true)
            {
                SaveUsersToFileJson(filepath);
                var index = Applications.IndexOf(currentapplication);
                Applications[index] = currentapplication;
            }
        }

        private void DeleteButton(object parameter)
        {
            if (System.Windows.MessageBox.Show("Видалити цю заявку?", "Підтвердження", System.Windows.MessageBoxButton.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                Applications.Remove(currentapplication);
                SaveUsersToFileJson(filepath);
                currentapplication = null;
            }
        }

        private void CheckButton(object parameter)
        {
            FullInfo infoWindow = new FullInfo();
            infoWindow.DataContext = currentapplication;
            infoWindow.ShowDialog();
        }
        private void ApplyFilter(object parameter)
        {
            string filterType = parameter as string;
            ICollectionView view = CollectionViewSource.GetDefaultView(Applications);

            if (string.IsNullOrWhiteSpace(filterType) || filterType == "All")
            {
                view.Filter = null;
            }
            else
            {
                view.Filter = (obj) =>
                {
                    if (obj is WorkerApplication app)
                    {
                        return app.Education != null && app.Education.Equals(filterType, StringComparison.OrdinalIgnoreCase);
                    }
                    return false;
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}