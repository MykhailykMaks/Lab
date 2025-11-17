using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Lab_4_2_ 
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, double> fuelPrices = new Dictionary<string, double>
        {
            { "А-76", 48.50 },
            { "А-92", 58.10 },
            { "А-95", 60.30 },
            { "Дизель", 70.00 },
            { "Газ", 32.60 }
        };

        private Dictionary<string, double> cafePrices = new Dictionary<string, double>
        {
            { "hotdogCheckBox", 45.00 },
            { "hamburgerCheckBox", 60.00 },
            { "friesCheckBox", 35.00 },
            { "cokeCheckBox", 25.00 },
            { "coffeeCheckBox", 30.00 }
        };

        private double dailyTotalRevenue = 0;

        public MainWindow()
        {
            InitializeComponent();
            SetupApplication();
        }

        private void SetupApplication()
        {
            costForHotdog.Text = cafePrices["hotdogCheckBox"].ToString("F2");
            costForHamburger.Text = cafePrices["hamburgerCheckBox"].ToString("F2");
            costForFries.Text = cafePrices["friesCheckBox"].ToString("F2");
            costForCoke.Text = cafePrices["cokeCheckBox"].ToString("F2");
            costForCoffee.Text = cafePrices["coffeeCheckBox"].ToString("F2");
            typeofOil.SelectedIndex = 2;
        }

        private void TypeofOilChanged(object sender, SelectionChangedEventArgs e)
        {
            if (costForLiter == null) return;
            ComboBoxItem selectedItem = (ComboBoxItem)typeofOil.SelectedItem;
            string selectedFuel = (string)selectedItem.Content;
            costForLiter.Text = fuelPrices[selectedFuel].ToString("F2");
            CalculateGasTotal();
        }

        private void CalculateType_Checked(object sender, RoutedEventArgs e)
        {
            if (CountTextBox == null || SumTextBox == null) return;

            if (Count.IsChecked == true)
            {
                CountTextBox.IsEnabled = true;
                SumTextBox.IsEnabled = false;
                SumTextBox.Text = "0";

                GasTotalGroupBox.Header = "До оплати:";
                GasTotalUnitTextBlock.Text = "грн";
            }
            else
            {
                CountTextBox.IsEnabled = false;
                CountTextBox.Text = "0";
                SumTextBox.IsEnabled = true;

                GasTotalGroupBox.Header = "До видачі:";
                GasTotalUnitTextBlock.Text = "л.";
            }
            CalculateGasTotal();
        }

        private void GasTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateGasTotal();
        }
        private void CalculateGasTotal()
        {
            if (TotalCostForOil == null) return;
            double.TryParse(costForLiter.Text, out double price);
            if (price == 0) return;
            if (Count.IsChecked == true)
            {
                int.TryParse(CountTextBox.Text, out int liters);
                double total = price * liters;
                TotalCostForOil.Text = total.ToString("F2");
            }
            else
            {
                double.TryParse(SumTextBox.Text.Replace(",", "."), out double sum);
                double totalLiters = sum / price;
                TotalCostForOil.Text = totalLiters.ToString("F2");
            }
        }

        private void CafeCheckBox_Toggled(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            string chkName = chk.Name;
            string txtName;
            if (chkName == "friesCheckBox")
            {
                txtName = "CountOffriesBox";
            }
            else
            {
                txtName = "CountOf" + chkName.Replace("CheckBox", "sBox");
            }
            TextBox countBox = (TextBox)this.FindName(txtName);

            if (countBox == null) return;

            if (chk.IsChecked == true)
            {
                countBox.IsEnabled = true;
                countBox.Text = "1";
            }
            else
            {
                countBox.IsEnabled = false;
                countBox.Text = "0";
            }
        }
        private void CafeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateCafeTotal();
        }
        private void CalculateCafeTotal()
        {
            if (TotalCostInCafe == null) return;
            double total = 0;
            if (hotdogCheckBox.IsChecked == true)
            {
                int.TryParse(CountOfhotdogsBox.Text, out int count);
                total += cafePrices["hotdogCheckBox"] * count;
            }
            if (hamburgerCheckBox.IsChecked == true)
            {
                int.TryParse(CountOfhamburgersBox.Text, out int count);
                total += cafePrices["hamburgerCheckBox"] * count;
            }
            if (friesCheckBox.IsChecked == true)
            {
                int.TryParse(CountOffriesBox.Text, out int count);
                total += cafePrices["friesCheckBox"] * count;
            }
            if (cokeCheckBox.IsChecked == true)
            {
                int.TryParse(CountOfcokesBox.Text, out int count);
                total += cafePrices["cokeCheckBox"] * count;
            }
            if (coffeeCheckBox.IsChecked == true)
            {
                int.TryParse(CountOfcoffeesBox.Text, out int count);
                total += cafePrices["coffeeCheckBox"] * count;
            }

            TotalCostInCafe.Text = total.ToString("F2");
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            double oilTotal = 0;
            if (Count.IsChecked == true)
            {
                double.TryParse(TotalCostForOil.Text, out oilTotal);
            }
            else
            {
                double.TryParse(SumTextBox.Text, out oilTotal);
            }
            double cafeTotal = 0;
            double.TryParse(TotalCostInCafe.Text, out cafeTotal);
            double total = oilTotal + cafeTotal;
            TotalSum.Text = total.ToString("F2");
            dailyTotalRevenue += total;
            GasPaymentText.Text = oilTotal.ToString("F2");
            CafePaymentText.Text = cafeTotal.ToString("F2");
        }
        private void BestOilClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show($"Загальна виручка за день: {dailyTotalRevenue.ToString("F2")} грн",
                            "Робочий день закінчено");
        }
    }
}