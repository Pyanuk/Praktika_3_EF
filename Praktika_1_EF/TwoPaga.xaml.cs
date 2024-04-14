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


    public partial class TwoPaga : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public TwoPaga()
        {
            InitializeComponent();
            ClientDataGrid.ItemsSource = con.CLIENT.ToList();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            CLIENT a = new CLIENT();
            a.SURNAME = surname.Text;
            a.NAME_CLIENT = name.Text;
            a.MIDDLE_NAME = midle.Text;
            con.CLIENT.Add(a);
            con.SaveChanges();
            ClientDataGrid.ItemsSource = con.CLIENT.ToList();

        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if(ClientDataGrid.SelectedItem != null)
            {
                con.CLIENT.Remove(ClientDataGrid.SelectedItem as CLIENT);
                con.SaveChanges();
                ClientDataGrid.ItemsSource = con.CLIENT.ToList();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if(ClientDataGrid.SelectedItem != null)
            {
                con.SaveChanges();
            }
        }

        private void ClientDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ClientDataGrid.SelectedItem != null)
            {
                var select = ClientDataGrid.SelectedItem as CLIENT;
                select.SURNAME = surname.Text;
                select.NAME_CLIENT = name.Text;
                select.MIDDLE_NAME = midle.Text;
                con.SaveChanges();
                ClientDataGrid.ItemsSource = con.CLIENT.ToList();

            }
        }
    }
}
