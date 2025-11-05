using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Lab_4_1_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isResultOnDisplay = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add0(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "0";
            }
            else
            {
                Calculations.Text += "0";
            }
        }
        private void Add1(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "1";
            }
            else
            {
                Calculations.Text += "1";
            }
        }
        private void Add2(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "2";
            }
            else
            {
                Calculations.Text += "2";
            }
        }
        private void Add3(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "3";
            }
            else
            {
                Calculations.Text += "3";
            }
        }
        private void Add4(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "4";
            }
            else
            {
                Calculations.Text += "4";
            }
        }
        private void Add5(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "5";
            }
            else
            {
                Calculations.Text += "5";
            }
        }
        private void Add6(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "6";
            }
            else
            {
                Calculations.Text += "6";
            }
        }
        private void Add7(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "7";
            }
            else
            {
                Calculations.Text += "7";
            }
        }
        private void Add8(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "8";
            }
            else
            {
                Calculations.Text += "8";
            }
        }
        private void Add9(object sender, RoutedEventArgs e)
        {
            if (Calculations.Text == "" || isResultOnDisplay)
            {
                Calculations.Text = "9";
            }
            else
            {
                Calculations.Text += "9";
            }
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
            }
            string currentText = Calculations.Text;
            if (currentText.EndsWith(" "))
            {
                return;
            }
            Calculations.Text += " / ";
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
            }
            string currentText = Calculations.Text;
            if (currentText.EndsWith(" "))
            {
                return;
            }
            Calculations.Text += " * ";
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
            }
            string currentText = Calculations.Text;
            if (currentText.EndsWith(" "))
            {
                return;
            }
            Calculations.Text += " - ";
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
            }
            string currentText = Calculations.Text;
            if (currentText.EndsWith(" "))
            {
                return;
            }
            Calculations.Text += " + ";
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            string allCalculate = Calculations.Text;
            string[] parts;
            string operation = "";
            if (allCalculate.Contains(" + "))
            {
                parts = allCalculate.Split(new string[] { " + " }, StringSplitOptions.None);
                operation = "+";
            }
            else if (allCalculate.Contains(" - "))
            {
                parts = allCalculate.Split(new string[] { " - " }, StringSplitOptions.None);
                operation = "-";
            }
            else if (allCalculate.Contains(" * "))
            {
                parts = allCalculate.Split(new string[] { " * " }, StringSplitOptions.None);
                operation = "*";
            }
            else if (allCalculate.Contains(" / "))
            {
                parts = allCalculate.Split(new string[] { " / " }, StringSplitOptions.None);
                operation = "/";
            }
            else
            {
                return;
            }
            if (parts.Length != 2)
            {
                Calculations.Text = "Error!!";
                return;
            }
            if(double.TryParse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double symbol1) &&
               double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double symbol2))
            {
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = symbol1 + symbol2;
                        break;
                    case "-":
                        result = symbol1 - symbol2;
                        break;
                    case "*":
                        result = symbol1 * symbol2;
                        break;
                    case "/":
                        if (symbol2 == 0)
                        {
                            Calculations.Text = "Error!!(Div by 0)";
                            return;
                        }
                        result = symbol1 / symbol2;
                        break;
                }
                LastCalculations.Text = allCalculate;
                Calculations.Text = result.ToString();
                isResultOnDisplay = true;
            }
        }

        private void DeleteAllCalculations(object sender, RoutedEventArgs e)
        {
            isResultOnDisplay = false;
            LastCalculations.Text = "";
            Calculations.Text = "";
        }

        private void DeleteNowCalculations(object sender, RoutedEventArgs e)
        {
            isResultOnDisplay = false;
            Calculations.Text = "";
        }

        private void AddPoint(object sender, RoutedEventArgs e)
        {
            string currentText = Calculations.Text;
            string currentNumber = "";
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
                return;
            }
            if (Calculations.Text.EndsWith(" ") || Calculations.Text.EndsWith("."))
            {
                return;
            }
            int lastOperationIndex = currentText.LastIndexOf(' ');
            if (lastOperationIndex == -1)
            {
                currentNumber = currentText;
            }
            else
            {
                currentNumber = currentText.Substring(lastOperationIndex + 1);
            }
            Calculations.Text += ".";
        }
        private void DeleteLastNumber(object sender, RoutedEventArgs e)
        {
            string currentText = Calculations.Text;
            if (currentText.Contains("Error") || isResultOnDisplay)
            {
                Calculations.Text = "";
                isResultOnDisplay = false;
                return;
            }
            if (currentText.Length > 0)
            {
                if (currentText.EndsWith(" "))
                {
                    currentText = currentText.Substring(0, currentText.Length - 3);
                }
                else
                {
                    currentText = currentText.Substring(0, currentText.Length - 1);
                }
            }
            if (string.IsNullOrEmpty(currentText))
            {
                Calculations.Text = "";
            }
            else
            {
                Calculations.Text = currentText;
            }
        }
    }
}