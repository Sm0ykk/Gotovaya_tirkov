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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Page
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string newLogin = NewLoginTextBox.Text;
            string newPassword = NewPasswordBox.Password;

            // Логика регистрации нового пользователя
            if (RegisterUser(newLogin, newPassword))
            {
                MessageBox.Show("Умпешная регистрация!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации.");
            }
        }

        private bool RegisterUser(string newLogin, string newPassword)
        {
            // Здесь должна быть логика регистрации нового пользователя
            // Например, добавление в базу данных
            return !string.IsNullOrEmpty(newLogin) && !string.IsNullOrEmpty(newPassword);
        }
    }
}
