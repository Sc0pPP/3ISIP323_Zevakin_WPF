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

namespace WpfApp7.pages
{
    /// <summary>
    /// Логика взаимодействия для Bid.xaml
    /// </summary>
    public partial class Bid : Page
    {
        public Bid()
        {
            InitializeComponent();
        }
        private void phone_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]);
            Car.phone = phone.Text;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(FIO.Text)) | (string.IsNullOrWhiteSpace(phone.Text)) | (string.IsNullOrWhiteSpace(pochta.Text)))
            {
                MessageBox.Show("незаполнено");
                return;
            }


            MessageBox.Show($"Общая Стоимость-{Car.cost}\n" +
                $"Двигатель-{Car.engine}" +
                $"Цвет-{Car.color}" +
                $"options-{Car.fuloptions}" +
                $"Сумма кредита {Car.sum_of_credit}" +
                $"Платеж по кредиту {Car.plat_credit}" +
                $"Телефон-{Car.phone}" +
                $"Фио-{Car.FIO}");

            
        }

        private void FIO_TextChanged(object sender, TextChangedEventArgs e)
        {
            Car.FIO = FIO.Text;
        }
    }
}
