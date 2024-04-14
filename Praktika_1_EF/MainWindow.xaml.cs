using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Praktika_1_EF
{
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new FirstPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageFrame1.Content = new TwoPaga();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageFrame2.Content = new Three();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PageFrame3.Content = new FourPage();
        }

        private void full_info_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            Close();
        }
    }
}
