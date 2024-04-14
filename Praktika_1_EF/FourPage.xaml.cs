using System;
using System.Collections.Generic;
using System.Data;
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
 
    public partial class FourPage : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public FourPage()
        {
            InitializeComponent();
            CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();

            CUSTOMER_ORDERComboBox.ItemsSource = con.NAME_COFFEE.ToList();
            CUSTOMER_ORDERComboBox.DisplayMemberPath = "ID_NAME_COFFEE_HOUSE";

            CUSTOMER_ORDERComboBox1.ItemsSource = con.CLIENT.ToList();
            CUSTOMER_ORDERComboBox1.DisplayMemberPath = "ID_CLIENT";

            CUSTOMER_ORDERComboBox2.ItemsSource = con.ORDER_COFFEE.ToList();
            CUSTOMER_ORDERComboBox2.DisplayMemberPath = "ID_ORDER_COFFEE";
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {

            CUSTOMER_ORDER a = new CUSTOMER_ORDER();
            a.NAME_COFFEE_ID = int.Parse(adres.Text);
            a.CLIENT_ID = int.Parse(clietn.Text);
            a.ORDER_COFFEE_ID = int.Parse(cofee.Text);
            con.CUSTOMER_ORDER.Add(a);
            con.SaveChanges();
            CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                con.CUSTOMER_ORDER.Remove(CUSTOMER_ORDERDataGrid.SelectedItem as CUSTOMER_ORDER);
                con.SaveChanges();
                CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();

            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            con.SaveChanges();
        }

        private void CUSTOMER_ORDERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                var select = CUSTOMER_ORDERDataGrid.SelectedItem as CUSTOMER_ORDER;
                select.NAME_COFFEE_ID = int.Parse(adres.Text);
                select.CLIENT_ID = int.Parse(clietn.Text);
                select.ORDER_COFFEE_ID = int.Parse(cofee.Text);
                con.SaveChanges();
                CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox.SelectedItem != null)
            {
                var selectedItem = CUSTOMER_ORDERComboBox.SelectedItem as NAME_COFFEE;
                MessageBox.Show(selectedItem.TITLE);
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox1.SelectedItem != null)
            {
                var selectedItem = CUSTOMER_ORDERComboBox1.SelectedItem as CLIENT;
                MessageBox.Show(selectedItem.SURNAME);
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox2.SelectedItem != null)
            {
                var selectedItem = CUSTOMER_ORDERComboBox2.SelectedItem as ORDER_COFFEE;
                MessageBox.Show(selectedItem.COFFEE_NAME);
            }
        }

    }
}
