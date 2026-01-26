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
    
    public partial class SecondPage : Page
    {
        public List<Tovary> Tov = new List<Tovary>();
        public List<product> cartProduct=new List<product>();
        public SecondPage(List<Tovary> tov, List<product> CartProduct)
        {
            InitializeComponent();
            Tov = tov;
            cartProduct= CartProduct;
            prod.ItemsSource = CartProduct;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThirdPage(Tov as List<Tovary> ,cartProduct as List<product>));
        }
    }
}
