using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToDo_Manager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private string testPW = "Seba";

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pwBox.Password == testPW) //implement db connection and account management
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.loginEnterButton.IsEnabled = false;
                loginWindow.registerbutton.IsEnabled = false;

                loginWindow.pwLabel.Visibility = Visibility.Collapsed;
                loginWindow.pwBox.Visibility = Visibility.Collapsed;
                loginWindow.loginEnterButton.Visibility = Visibility.Collapsed;
                loginWindow.registerbutton.Visibility = Visibility.Collapsed;
                loginWindow.enterRect.Visibility = Visibility.Collapsed;
                loginWindow.pwBoxBorder.Visibility = Visibility.Collapsed;
                loginWindow.hoI_IV_Icon.Visibility = Visibility.Visible;

                loginWindow.Show();

                this.Close();

                await Task.Delay(3000);

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

            }
            else if (pwBox.Password == "")
            {
                MessageBox.Show("No password given!");
            }
            else
            {
                pwBox.Password = "";
                MessageBox.Show("Wrong password!");
            }
        }

        private void registerbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Implement account management\nImplement database");//db connection and account mngmt
        }
    }
}
