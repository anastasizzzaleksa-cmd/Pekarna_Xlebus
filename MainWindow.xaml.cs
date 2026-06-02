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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace API_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string snils = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        private async void GetDataButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                using (HttpClient client = new HttpClient())
                {

                    string url = "http://localhost:4444/TransferSimulator/snils";

                    string jsonAnswer = await client.GetStringAsync(url);




                    jsonAnswer = jsonAnswer.Replace("{", "");
                    jsonAnswer = jsonAnswer.Replace("}", "");
                    jsonAnswer = jsonAnswer.Replace("\"", "");
                    jsonAnswer = jsonAnswer.Replace("value :", "");

                    snils = jsonAnswer.Trim();


                    txtBoxFullNameText.Text = snils;


                    txtBoxResultText.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка API", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(snils))
            {
                txtBoxResultText.Text = "Сначала получите данные";


                return;
            }




            string forbiddenSymbols = "0123456789!@#$%^&*():;_-+=[]{}<>?/|\\&";



            if (snils.Intersect(forbiddenSymbols).Count() > 0)
            {
                txtBoxResultText.Text = "СНИЛС не корректен";
                return;
            }

            txtBoxResultText.Text = "СНИЛС корректен";
        }
    }
}
