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

namespace Lab_3
{
    /// <summary>
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == Button1)
            {
                ChangeVisibility(Button1);
                ChangeVisibility(Button2);
            }
            else if (clickedButton == Button2)
            {
                ChangeVisibility(Button1);
                ChangeVisibility(Button2);
                ChangeVisibility(Button3);
            }
            else if (clickedButton == Button3)
            {
                ChangeVisibility(Button2);
                ChangeVisibility(Button3);
                ChangeVisibility(Button4);
            }
            else if (clickedButton == Button4)
            {
                ChangeVisibility(Button3);
                ChangeVisibility(Button4);
                ChangeVisibility(Button5);
            }
            else if (clickedButton == Button5)
            {
                ChangeVisibility(Button4);
                ChangeVisibility(Button5);
            }

            CheckForWin();
        }
        private void ChangeVisibility(Button button)
        {
            if (button.Visibility == Visibility.Visible)
            {
                button.Visibility = Visibility.Hidden;
            }
            else
            {
                button.Visibility = Visibility.Visible;
            }
        }
        private void CheckForWin()
        {
            if (Button1.Visibility == Visibility.Hidden &&
                Button2.Visibility == Visibility.Hidden &&
                Button3.Visibility == Visibility.Hidden &&
                Button4.Visibility == Visibility.Hidden &&
                Button5.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Перемога!");
            }
        }
    }
}
