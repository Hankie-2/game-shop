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
using UIKitTutorials.Entity;
using UIKitTutorials.Service;

namespace UIKitTutorials.Windows
{
    /// <summary>
    /// Логика взаимодействия для GameInfo.xaml
    /// </summary>
    public partial class GameInfo : Window
    {
        private int Id;
        private GameService gameService;
        private Game game;
        private UserLogin userLogin = UserLogin.getUser();
        private UserService userService;
        private PurchaseService purchaseService;
        public GameInfo(int id)
        {
            purchaseService = new PurchaseService();
            gameService = new GameService();
            Database.Connect(new DatabaseConfiguration());
            userService = new UserService(Database.connection);
            InitializeComponent();
            Id = id;
            game = gameService.GameGetById(id);
            gameInfoName.Content = game.Title;
            gameInfoDate.Content = game.ReleaseDate;
            gameInfoPrice.Content = game.Price + "$";
            gameInfoDescription.Text = game.Description;
            gameInfoPublisher.Content = game.PusblisherName;
            publisherCountry.Content = game.PublisherCountry;
            publisherWebsite.Content = game.PublisherWebsite;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            bool isEnoughMoney = userService.DeductMoneyById(userLogin.Id, game.Price);
            if(isEnoughMoney)
            {
                bool isBought = purchaseService.Create(userLogin.Id,game.Id);
                if(isBought)
                {
                    MessageBox.Show("Вы успешно купили игру '" + game.Title + "'!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
