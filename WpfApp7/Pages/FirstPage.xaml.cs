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
using static System.Net.Mime.MediaTypeNames;


namespace WpfApp7.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public class product
    {
        public string path {  get; set; }
       
        public string description {  get; set; }
    }
    public partial class FirstPage : Page
    {
        public static List<Tovary> tov = Core.Context.Tovary.ToList();
        public List<Tovary> cart = new List<Tovary>();
        List<product> List = new List<product>();
        public List<product>CartPtoduct= new List<product>();
        public FirstPage()
        {
            InitializeComponent();
            List<Tovary> tov = Core.Context.Tovary.ToList();
            foreach (Tovary tovar in tov)
            {
                List.Add(new product
                {
                    path = tovar.URL,
                    description = $"цена:{tovar.Price},Название:{tovar.Name}"
                });
            }
            List <string>urllist= tov.Select(u => u.URL).ToList();
            List<Tovary> Cart= new List<Tovary>();
            prod.ItemsSource = List;
            
        }
        private void BuyClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            var product = btn.DataContext as product;
            string TempPath= product.path;
            if (product != null)
            {
                foreach (product prod in List)
                {
                    if (product.path == prod.path) {
                    CartPtoduct.Add(prod);
                    }
                   
                }
                }
            foreach(Tovary tovar in tov)
            {
                if(tovar.URL== product.path) {
                    cart.Add(tovar);
            }
            }
            
        }

        private void Further_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondPage(cart as List<Tovary>));
        }
    }
}
