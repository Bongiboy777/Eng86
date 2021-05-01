using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using RadioApp;
namespace RadioGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer mp = new MediaPlayer();

        

        Radio radio = new Radio();
        public MainWindow()
        {
            
            
            InitializeComponent();
            




        }

        public void ToggleOnOff(object sender, RoutedEventArgs e)
        {
            if(TogglePower.IsChecked.Value == true)
            {
                radio.TurnOn();
                ChannelDisplay.Text = $"Channel {radio.Channel}";
                Console.WriteLine("Turning on");
                mp.Play();
            }
            else {
                radio.TurnOff();
                ChannelDisplay.Text = $"";
            }
        }

        private void ChangeChannel(object sender, RoutedEventArgs e)
        {
            if(radio.On)
            {
                int channelNum = Int16.Parse((sender as Button).Name.Remove(0, 7));
                radio.Channel = channelNum;
                ChannelDisplay.Text = $"{radio.Play()}";

                
            }
            
        }
    }
}
