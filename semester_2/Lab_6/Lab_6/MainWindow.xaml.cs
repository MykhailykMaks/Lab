using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new WorkerApplicationsManager();
        }
        private void SideMenu_Click(object sender, RoutedEventArgs e)
        {
            if (SideMenuColumn.Width.Value > 0)
            {
                SideMenuColumn.Width = new GridLength(0);
            }
            else
            {
                SideMenuColumn.Width = new GridLength(200);
            }
        }
        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Пошук...")
            {
                SearchTextBox.Text = "";
                SearchTextBox.Foreground = Brushes.Black;
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Пошук...";
                SearchTextBox.Foreground = Brushes.Gray;
            }
        }
    }
}