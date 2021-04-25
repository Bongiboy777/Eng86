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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static int runningsum;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            string input = ((Button)(sender)).Content.ToString();
            switch(input)
            {
                case "Del":
                    Cal.Text = Cal.Text.Length > 0 ? 
                        Cal.Text.Remove(Cal.Text.Length - 1) : "";
                    break;

                case "CLR":
                    Cal.Text = "";
                    break;

                case "=":
                    Cal.Text = Calculate(Cal.Text).ToString();
                    break;

                default:

                    Cal.Text = Cal.Text != "0"  && input != "0" ? Cal.Text + input: input;
                    break;
            }
           
        }

        public static long combine(long input)
        {
            int sum = 0;
            int[] output = Array.ConvertAll(input.ToString().ToCharArray(), element => (int)char.GetNumericValue(element));
            for (int i = 0; i < output.Length; i++)
            {
                sum += output[i];
            }
            return sum;
        }

        public static int Calculate(string calculation)
        {
            int output = 0;

            if (calculation.Contains('x'))
            {
                int product = 1;
                List<string> Factors = calculation.Split('x').ToList<string>();

                Factors.ForEach(delegate (string number)
                {
                    if (int.TryParse(number, out int num))
                    {
                        product = MathLib.Multiply(product, num);
                    }

                }

                );
                output += product;
            }

            if (calculation.Contains('/'))
            {
                int product = 1;
                List<string> Factors = calculation.Split('/').ToList<string>();

             
                output += MathLib.Divide(int.Parse(Factors[0]),int.Parse(Factors[1]));
            }

            if (calculation.Contains('+'))
            {
                int sum = 0;
                List<string> Adds = calculation.Split('+').ToList<string>();

                Adds.ForEach(delegate (string number)
                {
                    if(int.TryParse(number, out int num))
                    {
                         sum = MathLib.Add(sum, num);
                    }
                       
                }
                );
                output += sum;
            }

            if (calculation.Contains('-'))
            {
                int sum = 0;
                List<string> Adds = calculation.Split('-').ToList<string>();
                sum += int.Parse(Adds[0]);

                for (int i = 1; i < Adds.Count; i++)
                {
                    if (int.TryParse(Adds[i], out int num))
                    {
                        sum = MathLib.Subtract(sum, num);
                    }
                }
                    

                
                output += sum;
            }


            return output;

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

