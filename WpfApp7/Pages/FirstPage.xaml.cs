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


namespace WpfApp7.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public List<Movies> movies_bd = Core.Context.Movies.ToList();
        public FirstPage()
        {
            InitializeComponent();
            prod.ItemsSource = movies_bd;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfilePage());
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//rating
             List<Movies> MoviesRating = (List<Movies>)movies_bd.OrderByDescending(u => u.Rating).ToList();
            prod.ItemsSource = MoviesRating;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//name
            List<Movies> MoviesName = (List<Movies>)movies_bd.OrderBy(u => u.MovieName).ToList();
            prod.ItemsSource = MoviesName;
        }
    }
}
