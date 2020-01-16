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

namespace WPF_11___Checkbox
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

        private void cbAllToppings_Checked(object sender, RoutedEventArgs e)
        {
            bool? newVal = cbAllToppings.IsChecked;
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            if ((cbSalami.IsChecked == true) && (cbMushrooms.IsChecked == true) && (cbMozzarella.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }
            else if ((cbSalami.IsChecked == false) && (cbMushrooms.IsChecked == false) && (cbMozzarella.IsChecked == false))
            {
                cbAllToppings.IsChecked = false;
            }
            else
            {
                cbAllToppings.IsChecked = null;
            }
        }
    }
}
