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
    /// Логика взаимодействия для PanelUsers.xaml
    /// </summary>
    public partial class PanelUsers : Window
    {
        public PanelUsers(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = $"Здравствуйте, {userName}!";
        }
        private void BtnViewProducts_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается каталог товаров...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnViewOrders_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открываются мои заказы...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается профиль пользователя...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }
    }
}
    
