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

namespace Praktika_1_EF
{

    public partial class Three : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public Three()
        {
            InitializeComponent();
            ORDER_COFFEEDataGrid.ItemsSource = con.ORDER_COFFEE.ToList();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            ORDER_COFFEE a = new ORDER_COFFEE();
            a.COFFEE_NAME = cofee.Text;
            a.COFFEE_PRICE = int.Parse(price.Text);
            con.ORDER_COFFEE.Add(a);
            con.SaveChanges();
            ORDER_COFFEEDataGrid.ItemsSource = con.ORDER_COFFEE.ToList();
        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if(ORDER_COFFEEDataGrid.SelectedItem != null)
            {
                con.ORDER_COFFEE.Remove(ORDER_COFFEEDataGrid.SelectedItem as ORDER_COFFEE);
                con.SaveChanges();
                ORDER_COFFEEDataGrid.ItemsSource = con.ORDER_COFFEE.ToList();
            }
        }

        private void ORDER_COFFEEDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ORDER_COFFEEDataGrid.SelectedItem != null)
            {
                var select = ORDER_COFFEEDataGrid.SelectedItem as ORDER_COFFEE;
                select.COFFEE_NAME = cofee.Text;
                select.COFFEE_PRICE= int.Parse(price.Text);
                con.SaveChanges();
                ORDER_COFFEEDataGrid.ItemsSource = con.ORDER_COFFEE.ToList();

            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (ORDER_COFFEEDataGrid.SelectedItem != null)
            {
                con.SaveChanges();
            }
        }
    }
}
