using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_7
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            Loaded += AddWindow_Loaded;

        }
        private void AddWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataToUI();
        }
        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Zа-яА-ЯіІїЇєЄґҐ'\\s]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void OnAnyControlClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Input.CommandManager.InvalidateRequerySuggested();
        }
        private void LoadDataToUI()
        {
            if (this.DataContext is Student student)
            {
                switch (student.sex)
                {
                    case "Чоловік": Male.IsChecked = true; break;
                    case "Жінка": Female.IsChecked = true; break;
                }

            }
        }
        private void Age_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "0")
            {
                box.Text = string.Empty;
            }
        }

        private void Age_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                box.Text = "0";
            }
        }
    }
}
