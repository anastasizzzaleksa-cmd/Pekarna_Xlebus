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
    /// Логика взаимодействия для UserProducts.xaml
    /// </summary>
    public partial class UserProducts : Window
    {
        public UserProducts()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавление нового товара", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show($"Удалить {lstProducts.SelectedItem}?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    lstProducts.Items.Remove(lstProducts.SelectedItem);
                    MessageBox.Show("Товар удалён!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

