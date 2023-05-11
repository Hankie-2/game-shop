using ShopApplication.Configuration;
using ShopApplication.Entity;
using ShopApplication.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
using UIKitTutorials.Entity;
using UIKitTutorials.Service;

namespace UIKitTutorials.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {

        private UserService userService = new UserService(Database.connection);
        private UserLogin userLogin = UserLogin.getUser();
        private PurchaseService purchaseService = new PurchaseService();
        public AdminPanel()
        {
            InitializeComponent();
            Database.Connect(new DatabaseConfiguration());
            var users = userService.GetAll();
            var purchases = purchaseService.GetAll();
            usersCount.Content = "Количество пользователей: " + users.Count;
            panelName.Content = "Админ панель для " + userLogin.Name;
            soldGameCount.Content = "Количество покупок: " + purchases.Count;
            soldGameMoney.Content ="Количество покупок на сумму: " + countMoney(purchases) + "$";
        }

        private SqlDecimal countMoney(List<Purchase> purchases)
        {
            SqlDecimal count = 0;
            for (int i = 0; i < purchases.Count; i++)
            {
                count += purchases[i].Price;
            }
            return count;
        }

        private void createGameButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
