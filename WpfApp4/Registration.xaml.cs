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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            // Проверка на правильность ввода и наличие пользователя
            if (IsValidAdmin(login, password))
            {
                MessageBox.Show("Успешная авторизация!");
                Manager.MainFrame.Navigate(new HotelsPage());

            }
            else if (IsValidManager(login, password))
            {
                MessageBox.Show("Успешная авторизация!");
                Manager.MainFrame.Navigate(new AddEditPage(null));

            }
            //else if (IsValidUser(login, password))
            //{
              //  MessageBox.Show("Login successful!");
             //   Manager.MainFrame.Navigate(new ToursPage());
            //}

            else
            {
                MessageBox.Show("Неправильный пароль или логин.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            //RegisterWindow registerWindow = new RegisterWindow();
            Manager.MainFrame.Navigate(new ToursPage());
            //this.Close();
        }

        private bool IsValidAdmin(string login, string password)
        {

            return login == "admin" && password == "password";
        }
        private bool IsValidManager(string login, string password)
        {
            return login == "manager" && password == "321";
        }
       // private bool IsValidUser(string login, string password)
        //{
            // Здесь должна быть логика проверки пользователя
            // Например, проверка в базе данных
            //return login == "user" && password == "123";
        //}
    }
}
