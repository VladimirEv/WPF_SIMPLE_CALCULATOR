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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        double SecondNumber;
        double Total;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateAdd(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numA.Text);
            SecondNumber = Convert.ToDouble(numB.Text);

            Total = FirstNumber + SecondNumber;

            Result.Content = Total.ToString();

        }

        private void CalculateSubstract(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numA.Text);
            SecondNumber = Convert.ToDouble(numB.Text);

            Total = FirstNumber - SecondNumber;

            Result.Content = Total.ToString();
        }

        private void CalculateMuitiply(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numA.Text);
            SecondNumber = Convert.ToDouble(numB.Text);

            Total = FirstNumber * SecondNumber;

            Result.Content = Total.ToString();
        }

        private void CalculateDivide(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numA.Text);
            SecondNumber = Convert.ToDouble(numB.Text);

            Total = FirstNumber / SecondNumber;

            Result.Content = Total.ToString("#.###");
        }
    }
}
