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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pwBox.Password == testPW) //implement db connection and account management
            {

                ImageBrush backGroundBrush = new ImageBrush();

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri("C:\\Users\\xx\\source\\repos\\ToDo Manager\\ToDo Manager\\ressources\\game-icon.png");
                image.EndInit();

                backGroundBrush.ImageSource = image;

                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Background = backGroundBrush;
                loginWindow.pwLabel.Visibility = Visibility.Collapsed;
                loginWindow.pwBox.Visibility = Visibility.Collapsed;
                loginWindow.loginEnterButton.Visibility = Visibility.Collapsed;
                loginWindow.registerbutton.Visibility = Visibility.Collapsed;
                loginWindow.enterRect.Visibility = Visibility.Collapsed;
                loginWindow.hoI_IV_Icon.Visibility = Visibility.Visible;
                loginWindow.Show();

                Thread.Sleep(3000);
                //obiger block funktioniert nicht richtig, es wird ein blankes login fenster geladen ohne bildhintergrund,
                //dann folgt Main-Fenster und dann wird im hintergrund erst ein weiters login-fenster geöffnet mit den obigen code-änderungen

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }

        private void registerbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Implement Account Management\nImplement Database");//db connection and account mngmt
        }
    }
}
