using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Логика взаимодействия для Credit.xaml
    /// </summary> 
    //                                                    C - цена на авто   // Car.cost

    //P - первоначальный взнос Convert.ToInt32(vznos.text)

    //S - сумма кредита    сar.cost-Convert.ToInt32(vznos.text)   

    //r - годовая ставка        хз 12

    //n - срок в месяцах        Convert.ToInt32(srok)

    //A - ежемесячный платеж    

    //i - месячная процентная ставка
    public partial class Credit : Page
    {
        public Credit()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(vznos.Text)) | (string.IsNullOrWhiteSpace(srok.Text)))
            {
                MessageBox.Show("незаполнено");
                return;
            }
            
            // Входные данные
            double C = Car.cost;                       // цена автомобиля
            double P = Convert.ToDouble(vznos.Text);   // первоначальный взнос
            double r = 12.0;                           // годовая ставка (например, 12%)
            int n = Convert.ToInt32(srok.Text);             // срок кредита в месяцах

            // Расчет суммы кредита
            double S = C - P;                         // сумма кредита

            // Расчет месячной процентной ставки (в долях, а не в процентах)
            double i = r / 100 / 12;                   // r/100 - перевод в доли, /12 - месячная ставка

            // Расчет ежемесячного платежа по формуле аннуитета
            // A = S * (i * (1+i)^n) / ((1+i)^n - 1)
            double A;

            if (i == 0) // если процентная ставка 0%
            {
                A = S / n; // просто делим сумму кредита на количество месяцев
            }
            else
            {
                double temp = Math.Pow(1 + i, n); // (1+i)^n
                A = S * (i * temp) / (temp - 1);
            }
            perv.Text = vznos.Text;
            summ.Text=Convert.ToString(S);
            Car.sum_of_credit = Convert.ToInt32(S);
            Car.plat_credit=Convert.ToInt32(A);
            platezh.Text = Convert.ToString(A);


           
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Bid());
        }

        private void srok_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]);
        }
        private void vznos_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]);
        }

        
    }
}
