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
    /// Логика взаимодействия для ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        public List<Tovary> Tov = new List<Tovary>();
        public List<product> cartProduct = new List<product>();
        public List<Tovary> CurentCart= new List<Tovary>();
        public int curent_price = 0;
        public string Fio;
        public string index;
        public string adress;
        public string password;

        public ThirdPage(List<Tovary> tov, List<product> CartProduct)
        {
            InitializeComponent();
            Tov = tov;
            cartProduct = CartProduct;
            prod.ItemsSource = CartProduct;

            foreach (product prod in CartProduct)
            {
                foreach(Tovary tovar in Tov)
                {
                    if (prod.path == tovar.URL)
                    {
                        CurentCart.Add(tovar);
                    }
                }
            }
            foreach (Tovary tovar in CurentCart) {
                curent_price += tovar.Price;
            }
            
            AllPrice.Text = $"Общая сумма:{curent_price}";
        }

        private void FIO_TextChanged(object sender, TextChangedEventArgs e)
        {
            Fio=FIO.Text;
        }

        private void Index_TextChanged(object sender, TextChangedEventArgs e)
        {
            index = Index.Text;
        }

        private void Addres_TextChanged(object sender, TextChangedEventArgs e)
        {
            adress= Addres.Text;
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = Password.Text;
        }

        private void addorder_Click(object sender, RoutedEventArgs e)
        {
            Users User = new Users
            {
                Login = Fio,
                Password = password,
                info = $"index:{index},addres:{adress}"
            };
            Core.Context.Users.Add(User); // добавление пользователя в таблицу в БД
            Core.Context.SaveChanges(); // сохранение изменений в БД
            List<Users> ListUser= Core.Context.Users.ToList();
            int curentUserID= ListUser.First(u => u.Login == Fio).ID;
            foreach (Tovary tovar in CurentCart)
            {
                Order NewOrder = new Order
                {
                    UserID = curentUserID,
                    Date = DateTime.Now,
                    TovarID = tovar.ID
                };
                Core.Context.Order.Add(NewOrder); // добавление пользователя в таблицу в БД
            }
            Core.Context.SaveChanges(); // сохранение изменений в БД
            MessageBox.Show("Заказ оформлен всем спасибо,еще посидим");
        }
    }
}
