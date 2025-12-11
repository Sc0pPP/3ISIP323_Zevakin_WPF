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
    /// Логика взаимодействия для ColorDop.xaml
    /// </summary>
    public partial class ColorDop : Page
    {
        public static List<color> Color = Enum.GetValues(typeof(color))
                                              .Cast<color>() // Приведение типов
                                              .ToList(); // Преобразование в List
        public static List<options> options = Enum.GetValues(typeof(options))
                                              .Cast<options>() // Приведение типов
                                              .ToList(); // Преобразование в List
        public ColorDop()
        {
            InitializeComponent();
            rbutton1.Content = options[0];
            rbutton2.Content= options[1];
            rbutton3.Content = options[2];
            type_color.ItemsSource = Color;
        }
            
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((type_color.SelectedIndex == -1))
            {
                MessageBox.Show("незаполнено");
                return;
            }
            NavigationService.Navigate(new Costparametrs());
           
        }

        private void rbutton1_Checked(object sender, RoutedEventArgs e)
        {
            
            Car.option1 = true;
            if (Car.option1 == true) { 
            Car.cost+=(int)Enum.Parse(typeof(options), Convert.ToString((options)Enum.Parse(typeof(options), rbutton1.Content.ToString())));
            }
        }
        private void rbutton2_Checked(object sender, RoutedEventArgs e)
        {
           
            Car.option2 = true;
            if (Car.option2 == true)
            {
                Car.cost +=(int)Enum.Parse(typeof(options), Convert.ToString((options)Enum.Parse(typeof(options), rbutton2.Content.ToString())));
            }
        }
        private void rbutton3_Checked(object sender, RoutedEventArgs e)
        {
            Car.option3 = true;
            if (Car.option3 == true)
            {
                Car.cost +=(int)Enum.Parse(typeof(options), Convert.ToString((options)Enum.Parse(typeof(options), rbutton3.Content.ToString())));
            }
        }

        private void type_color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            color selectedColor = (color)Enum.Parse(typeof(color), type_color.SelectedItem.ToString());
            Car.color = selectedColor;
            Car.cost+= (int)Enum.Parse(typeof(color), Convert.ToString(selectedColor));
        }
    }
}
