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
            if (currentText.EndsWith(" ") || currentText.EndsWith(","))
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
            if (currentText.EndsWith(" ") || currentText.EndsWith(","))
            {
                return;
            }
            Calculations.Text += " * ";
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
                isResultOnDisplay = false;
            string t = Calculations.Text;
            if (string.IsNullOrEmpty(t))
            {
                Calculations.Text = "-";
                return;
            }

            if (t.EndsWith(" + ") || t.EndsWith(" * ") || t.EndsWith(" / ") || t.EndsWith(" - "))
            {
                Calculations.Text += "-";
                return;
            }
            if (!t.EndsWith(" ") && !t.EndsWith(","))
            {
                Calculations.Text += " - ";
            }
        }


        private void Plus(object sender, RoutedEventArgs e)
        {
            if (isResultOnDisplay)
            {
                isResultOnDisplay = false;
            }
            string currentText = Calculations.Text;
            if (currentText.EndsWith(" ") || currentText.EndsWith(","))
            {
                return;
            }
            Calculations.Text += " + ";
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            string all = Calculations.Text;
            string operation = "";
            int opIndex = -1;

            foreach (string operate in new[] { " + ", " - ", " * ", " / " })
            {
                int idx = all.IndexOf(operate, 1);
                if (idx > 0)
                {
                    operation = operate.Trim();
                    opIndex = idx;
                    break;
                }
            }
            if (opIndex == -1) return;
            string left = all.Substring(0, opIndex).Trim();
            string right = all.Substring(opIndex + 3).Trim();
            double.TryParse(left, NumberStyles.Any, CultureInfo.CurrentCulture, out double a);
            double.TryParse(right, NumberStyles.Any, CultureInfo.CurrentCulture, out double b);
            double result = 0;

            switch (operation)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    if (b == 0)
                    {
                        Calculations.Text = "Error!!(Div by 0)";
                        return;
                    }
                    result = a / b;
                    break;
            }

                LastCalculations.Text = all;
                Calculations.Text = result.ToString(CultureInfo.CurrentCulture);
                isResultOnDisplay = true;
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
            string dec = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string text = Calculations.Text ?? "";
            if (isResultOnDisplay)
            {
                if (!Calculations.Text.Contains(dec))
                {
                    Calculations.Text += dec;
                }

                isResultOnDisplay = false;
                return;
            }
            if (text.EndsWith(" "))
            {
                return;
            }
            int opIndex = text.LastIndexOf(' ');
            string currentNumber = opIndex == -1 ? text : text.Substring(opIndex + 1);
            if (currentNumber.Contains(dec))
                return;
            if (string.IsNullOrEmpty(currentNumber))
                Calculations.Text += "0" + dec;
            else
                Calculations.Text += dec;
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