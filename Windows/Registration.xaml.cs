using ShopApplication.Configuration;
using ShopApplication.Entity;
using ShopApplication.Service;
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
using UIKitTutorials;
using UIKitTutorials.Windows;

namespace ShopApplication.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private UserService userService;
        public Registration()
        {
            InitializeComponent();
            Database.Connect(new DatabaseConfiguration());
            userService = new UserService(Database.connection);
            Database.Connect(new DatabaseConfiguration());
        }

        private void goToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login window= new Login();
            this.Close();
            window.Show();
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            string name = registrationName.Text;
            string username = registrationUsername.Text;
            string password = registrationPassword.Password;
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите все поля!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            User user = userService.UserGetByUsername(username);
            if(user != null)
            {
                MessageBox.Show("Пользователь с никнеймом '" + username + "' уже существует!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                bool isCreated = userService.Create(name,username, password);
                if(isCreated)
                {
                    MessageBox.Show("Зарегестрировались!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Вы не зарегестрировались!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
    }
}
