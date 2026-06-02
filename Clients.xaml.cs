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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void BtnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lstClients.SelectedItem != null)
            {
                MessageBox.Show($"Детали клиента:\n{lstClients.SelectedItem}\n\nДата регистрации: 2024 г.\nВсего заказов: 5\nОбщая сумма покупок: 2,500 ₽",
                    "Детали клиента", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnViewOrders_Click(object sender, RoutedEventArgs e)
        {
            if (lstClients.SelectedItem != null)
            {
                MessageBox.Show($"История заказов клиента:\n{lstClients.SelectedItem}\n\nЗаказы:\n- Заказ №1: 389.97 ₽\n- Заказ №4: 499.97 ₽\n\nВсего: 2 заказа",
                    "История заказов", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра заказов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

