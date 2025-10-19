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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Task1Click(object sender, RoutedEventArgs e)
        {
            Task1 task1Window = new Task1();
            task1Window.Show();
        }
        private void Task2Click(object sender, RoutedEventArgs e)
        {
            Task2 task2Window = new Task2();
            task2Window.Show();
        }
        private void Task3Click(object sender, RoutedEventArgs e)
        {
            Task3 task3Window = new Task3();
            task3Window.Show();
        }
        private void Task4Click(object sender, RoutedEventArgs e)
        {
            Task4 task4Window = new Task4();
            task4Window.Show();
        }
        private void Task5Click(object sender, RoutedEventArgs e)
        {
            Task5 task5Window = new Task5();
            task5Window.Show();
        }
        private void Task6Click(object sender, RoutedEventArgs e)
        {
            Task6 task6Window = new Task6();
            task6Window.Show();
        }
    }
}
