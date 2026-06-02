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

namespace Pekarna_Xlebus
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        public Users(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = $"Здравствуйте, {userName}!";
        }


        private void BtnManageProducts_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Открывается управление товарами...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            // Здесь будет форма управления товарами

            ProductsManagement productsManagement = new ProductsManagement();
            productsManagement.Show();
        }


        private void BtnViewOrders_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Открывается просмотр заказов...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            // Здесь будет форма просмотра заказов

            OrdersView ordersView = new OrdersView();
            ordersView.Show();
        }


        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

            // Показываем окно авторизации заново
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }
    }
}
    

