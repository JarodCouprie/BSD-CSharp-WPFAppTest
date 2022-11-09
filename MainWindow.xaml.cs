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

namespace WpfApp1st
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }
        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reset");
        }
        private void Blue_Button(object sender, RoutedEventArgs e)
        {
            blue_Button.Background = yellow_Button.Background;
            red_Button.Background = blue_Button.Background;
            green_Button.Background = red_Button.Background;
            yellow_Button.Background = green_Button.Background;
        }
        private void Red_Button(object sender, RoutedEventArgs e)
        {
            red_Button.Background = Brushes.Blue;
        }
        private void Green_Button(object sender, RoutedEventArgs e)
        {
            red_Button.Background = Brushes.Blue;
        }
        private void Yellow_Button(object sender, RoutedEventArgs e)
        {
            red_Button.Background = Brushes.Blue;
        }
    }
}
