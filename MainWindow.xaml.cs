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

namespace PChMI
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

        private List<Customer> LoadPrepareData()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer()
            {
                FIO = "Иванов Иван Иванович",
                Tel = "+7 (999) 654-32-10",
                Adress = "Москва, ул. Ленина, д. 43"
            });

            return customer;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonLight_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DarkWhiteBackground"] = new SolidColorBrush(Colors.White);
            this.Resources["DarkWhiteText"] = new SolidColorBrush(Colors.Black);
        }

        private void buttonDark_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DarkWhiteBackground"] = new SolidColorBrush(Colors.Aquamarine);
            this.Resources["DarkWhiteText"] = new SolidColorBrush(Colors.Red);
        }

        private void WhiteDark_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NavigationWindow win = new NavigationWindow();
            win.Content = new PageHelp();
            win.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPrepareData();
        }
    }
}
