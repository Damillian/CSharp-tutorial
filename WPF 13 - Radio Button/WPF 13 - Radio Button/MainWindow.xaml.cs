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

namespace WPF_13___Radio_Button
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton checkedRadioButton = (RadioButton)sender;
            if (checkedRadioButton.Name == "rbYes")
                MessageBox.Show("Thank you!");
            else if (checkedRadioButton.Name == "rbNo")
                MessageBox.Show("Wow, harsh...");
            else
                MessageBox.Show("Aww come on, say yes.");
        }
    }
}
