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
using CalculatorLib;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public double num1, num2;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        public void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            string input = ((Button)(sender)).Content.ToString();
            CalculationEntry.Text += input;

        }

        public void AddButtonClick(object sender, RoutedEventArgs e)
        {

            
        }

        public void SubtractButtonClick(object sender, RoutedEventArgs e)
        {

            
        }

        public void MultiplyButtonClick(object sender, RoutedEventArgs e)
        {

            
        }

        public void DivideButtonClick(object sender, RoutedEventArgs e)
        {

            //Result.Content = double.TryParse(Textbox1.Text, out num1) && double.TryParse(Textbox2.Text, out num2)
            //                    ? MathLib.Add(num1, num2) : "Input Error.";
        }
    }
}
