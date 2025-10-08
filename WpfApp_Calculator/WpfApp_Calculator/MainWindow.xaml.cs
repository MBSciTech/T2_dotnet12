using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Calculator
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

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = "";
        }

        private void modulo_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Convert.ToDecimal(Display.Content)/100;

        }

        private void plusminus_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Convert.ToInt32(Display.Content) * (-1);

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "7";

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "8";

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "9";

        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "*";

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "4";

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "5";

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "6";

        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "-";

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "3";

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "2";

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "1";

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "+";

        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + ".";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "0";
        }

        private void eqa_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = new DataTable().Compute(Display.Content.ToString(), "");

        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = Display.Content + "/";

        }
    }
}