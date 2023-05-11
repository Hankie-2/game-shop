using ShopApplication.Configuration;
using ShopApplication.Entity;
using ShopApplication.Service;
using ShopApplication.Windows;
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
using System.Windows.Shapes;

namespace UIKitTutorials.Windows
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private UserService userService;
        public Login()
        {
            InitializeComponent();
            Database.Connect(new DatabaseConfiguration());
            userService = new UserService(Database.connection);
            Database.Connect(new DatabaseConfiguration());
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = loginNickname.Text;
            string password = loginPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль или логин!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            User user = userService.UserGetByUsernameAndPassword(username, password);
            if (user == null)
            {
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                UserLogin.Instance(user.Id, user.Name, user.Password, user.Username, user.Role, user.Wallet, user.CreatedAt);
                if (user.Role.Equals("CLIENT"))
                {
                    MainWindow window = new MainWindow();
                    this.Close();
                    window.Show();
                }else if (user.Role.Equals("ADMIN"))
                {
                    AdminPanel window = new AdminPanel();
                    this.Close();
                    window.Show();
                }
                MessageBox.Show("Правильный логин и пароль!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();

        }
    }
}
