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

namespace Praktika_1_EF
{
   
    public partial class Window1 : Window
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public Window1()
        {
            InitializeComponent();
            Info_DataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Info_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[11].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[13].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[14].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[15].Visibility = Visibility.Collapsed;
            Info_DataGrid.Columns[16].Visibility = Visibility.Collapsed;

        }
    }
}
