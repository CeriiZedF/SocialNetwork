using SocialNetwork.Sql;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SocialNetwork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SelectWindow : Window
    {
        LoginWindow loginWindow;
        RegisterWindow registerWindow;

        public SelectWindow()
        {
            InitializeComponent();
            loginWindow = new LoginWindow();
            registerWindow = new RegisterWindow();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            loginWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            loginWindow.Close();
            registerWindow.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            registerWindow.Show();
        }
    }

    public class Pair
    {
        public String Key { get; set; } = null!;
        public String? Value { get; set; }
    }
}