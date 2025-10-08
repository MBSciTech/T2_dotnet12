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

namespace WpfApp1_Events
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

        private void txtblock_MouseLeave(object sender, MouseEventArgs e)
        {
            txtblock.Text = "Haish mouse leaved";
        }

        private void txtblock_MouseEnter(object sender, MouseEventArgs e)
        {
            txtblock.Text = "Ouch mouse entered";
        }

        private void lblname_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblname.Content = "Label Clicked!";
        }

        private void txtbox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtbox.Background = System.Windows.Media.Brushes.LightBlue;
        }

        private void txtbox_LostFocus(object sender, RoutedEventArgs e)
        {
            txtbox.Background = Brushes.LightCyan;
        }

        private void pwdInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Title = "Password length is " + pwdInput.Password.Length;
        }

        private void pwdInput_GotFocus(object sender, RoutedEventArgs e)
        {
            pwdInput.Background = Brushes.LightPink;
        }

        private void pwdInput_LostFocus(object sender, RoutedEventArgs e)
        {
            pwdInput.Background = Brushes.White;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblname.Content = txtbox.Text;
        }

        private void txtbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                MessageBox.Show("Digits are not allowed");
            }
        }

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSubmit.Background = Brushes.LightPink;
            btnSubmit.Content = "Hovering";
        }

        private void btnSubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSubmit.Background = Brushes.Green;
            btnSubmit.Content = "Submit";
        }

        private void rbOption1_Unchecked(object sender, RoutedEventArgs e)
        {
            Title = "Radio button unchecked";
        }

        private void rbOption2_Checked(object sender, RoutedEventArgs e)
        {
            Title = ((RadioButton)sender).Content + "Selected!";

        }

        private void rbOption1_Checked(object sender, RoutedEventArgs e)
        {
            Title = ((RadioButton)sender).Content + "Selected!";
        }

        private void rbOption2_Unchecked(object sender, RoutedEventArgs e)
        {
            Title = "Radio button unchecked";
        }

        private void chkAccept_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Turms are accepted");
        }

        private void chkAccept_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Turms are not accepted");
        }

        

        private void chkAccept_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Indeterminate state");
        }

        private void imgLogo_MouseEnter(object sender, MouseEventArgs e)
        {
            lblname.Content = "Hovering of Maharshi's Image Ee hat!";
        }

        private void imgLogo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Maharshi ni image click thai gai chhe!");
        }

        private void sldVolumn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblname.Content = "Volume " + sldVolumn.Value.ToString("0");
        }

        private void sldVolumn_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            lblname.Content = "Slider draging started";
        }

        private void sldVolumn_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            lblname.Content = "Slider draging Completed";
        }

        private void cldEvent_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            lblname.Content = "Selected Date : " + cldEvent.SelectedDate?.ToShortDateString();
        }

        private void cldEvent_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            MessageBox.Show("calendar Mounth changed");
        }

        private void dpSelectedDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lblname.Content = "Pciked Date is " + dpSelectedDate.SelectedDate?.ToShortDateString();
        }

        private void dpSelectedDate_CalendarOpened(object sender, RoutedEventArgs e)
        {
            lblname.Content = "Date picker Opened!";
        }

        private void dpSelectedDate_CalendarClosed(object sender, RoutedEventArgs e)
        {
            lblname.Content = "Date picker Closed!";

        }
    }
}