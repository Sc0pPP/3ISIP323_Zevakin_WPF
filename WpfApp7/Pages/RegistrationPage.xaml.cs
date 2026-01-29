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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    /// 
    public partial class RegistrationPage : Page
    {
        public List<Users> Users_bd = Core.Context.Users.ToList();

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserPassword.Text) | string.IsNullOrWhiteSpace(PasswordProv.Text) | string.IsNullOrWhiteSpace(UserName.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (Users_bd.FirstOrDefault(u => u.Login == UserName.Text) != null)
            {
                MessageBox.Show("Логин Занят");
                return;

            }
            if (UserPassword.Text != PasswordProv.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }               
            Users newUser = new Users // создание нового пользователя
            {
                Login = UserName.Text,
                Password = UserPassword.Text,
            };

            Core.Context.Users.Add(newUser); // добавление пользователя в таблицу в БД
            Core.Context.SaveChanges(); // сохранение изменений в БД
            MessageBox.Show("Аккаунт создан");
        }
    }
}
