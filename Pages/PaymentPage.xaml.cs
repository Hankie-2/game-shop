using ShopApplication.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIKitTutorials.Entity;
using UIKitTutorials.Service;
using UIKitTutorials.Windows;

namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Lógica de interacción para PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {

        public static DataGrid dataGrid;
        private PurchaseService purchaseService;
        private ObservableCollection<Purchase> purchasesList = new ObservableCollection<Purchase>();
        private UserLogin userLogin = UserLogin.getUser();
        private SqlDecimal allSpendMoney = 0;
        public PaymentPage()
        {
            InitializeComponent();
            dataGrid = purchaseDataGrid;
            DataContext = this;
            purchaseService = new PurchaseService();
            Load();
            purchaseCount.Text = purchasesList.Count() + " покупок на сумму " + allSpendMoney + "$";
        }

        private void Load()
        {
            var purchases = purchaseService.GetAllById(userLogin.Id);
            foreach (var purchase in purchases)
            {
                purchasesList.Add(purchase);
                allSpendMoney += purchase.Price;
            }
            purchaseDataGrid.ItemsSource = purchasesList;
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (dataGrid.SelectedItem as Purchase).GameId;
            GameInfo window = new GameInfo(Id);
            window.ShowDialog();

        }


    }
}
