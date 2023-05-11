using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UIKitTutorials.Entity;
using UIKitTutorials.Service;
using UIKitTutorials.Windows;

namespace UIKitTutorials.Pages
{

    public partial class HomePage : Page
    {

        public static DataGrid dataGrid;
        private GameService gameService;
        private ObservableCollection<Game> gamesList = new ObservableCollection<Game>();

        public HomePage()
        {
            InitializeComponent();
            dataGrid = homeDataGrid;
            DataContext = this;
            gameService = new GameService();
            Load();
            gameCount.Text = gamesList.Count() + " игр";
        }

        private void Load()
        {
            var games = gameService.GetAll();
            foreach (var game in games)
            {
                gamesList.Add(game);
            }
            homeDataGrid.ItemsSource = gamesList;
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (dataGrid.SelectedItem as Game).Id;
            GameInfo window = new GameInfo(Id);
            window.ShowDialog();

        }

    }
}
