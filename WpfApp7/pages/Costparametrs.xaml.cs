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
    /// Логика взаимодействия для Costparametrs.xaml
    /// </summary>
    public partial class Costparametrs : Page
    {
        public static List<options> option = Enum.GetValues(typeof(options))
                                              .Cast<options>() // Приведение типов
                                              .ToList(); // Преобразование в List
        public Costparametrs()
        {
            InitializeComponent();
            string all_options="";
            cost.Text= "Итоговая стоимость"+Car.cost.ToString();
            marka.Text="кузов-"+((marka)Enum.Parse(typeof(marka), Car.marka.ToString()));
            engine.Text = "Двигатель-" + ((engine)Enum.Parse(typeof(engine), Car.engine.ToString()));
            color.Text = "Цвет-" + ((color)Enum.Parse(typeof(color), Car.color.ToString()));
            if (Car.option1 == true)
            {
                options.Text += (" "+(options)Enum.Parse(typeof(options), option[0].ToString()));
            }
            if (Car.option2 == true)
            {
                options.Text += "," +((options)Enum.Parse(typeof(options), option[1].ToString()));
            }
            if (Car.option3 == true)
            {
                options.Text += "," + ((options)Enum.Parse(typeof(options), option[2].ToString()));
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Credit());
        }
    }
}
