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
    /// Логика взаимодействия для OrdersView.xaml
    /// </summary>
    public partial class OrdersView : Window
    {
        public OrdersView()
        {
            InitializeComponent();
        }

        private void BtnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                MessageBox.Show($"Детали заказа:\n{lstOrders.SelectedItem}\n\nТовары:\n- Булочка с изюмом 2 шт\n- Хлеб 1 шт\n- Булочка с яблоками 1 шт",
                    "Детали заказа", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите заказ для просмотра!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

