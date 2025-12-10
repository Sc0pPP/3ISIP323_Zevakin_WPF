using System;
using System.Collections.Generic;
using System.Configuration;
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
   
    public partial class Engine : Page
    {
        
        /// <summary>
        /// Логика взаимодействия для Engine.xaml
        /// </summary>
        public static List<engine> engin = Enum.GetValues(typeof(engine))
                                              .Cast<engine>() // Приведение типов
                                              .ToList(); // Преобразование в List
        public static List<marka> mark= Enum.GetValues(typeof(marka))
                                              .Cast<marka>() // Приведение типов
                                              .ToList(); // Преобразование в List
        public Engine()
        {
            InitializeComponent();
            type_engine.ItemsSource = engin;
            type_car.ItemsSource = mark;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ColorDop());
        }

        private void type_car_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (type_car.SelectedItem != null)
            {
                marka selectedMark = (marka)Enum.Parse(typeof(marka), type_car.SelectedItem.ToString());
            }
        }

        private void type_engine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            engine selectedMark = (engine)Enum.Parse(typeof(engine), type_engine.SelectedItem.ToString());
        }
    }
}
