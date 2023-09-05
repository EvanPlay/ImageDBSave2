using ImageDBSave2.AplicationData;
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

namespace ImageDBSave2.PageMain
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        int role = 0;
        //Кнопка отключена
        //private void btEnter_Click(object sender, RoutedEventArgs e)
        //{
        //    AuthorizationMetod();
        //}

        private void btAdmin_Click(object sender, RoutedEventArgs e)
        {
            role = 1;
            SelectRoleMetod();
        }
        private void btModerator_Click(object sender, RoutedEventArgs e)
        {
            role = 2;
            SelectRoleMetod();
        }
        private void btUser_Click(object sender, RoutedEventArgs e)
        {
            role = 3;
            SelectRoleMetod();
        }
        //Метод проверки роли
        public void SelectRoleMetod()
        {
            switch(role)
            {
                case 1: MessageBox.Show("Admin_case");
                    AppFrame.frameMain.Navigate(new PageAdmin.PageMenuAdmin());
                    break;
                case 2: MessageBox.Show("Moderator_case");
                    AppFrame.frameMain.Navigate(new PageModerator.PageMenuModerator());
                    break;
                case 3: MessageBox.Show("User_case");
                    AppFrame.frameMain.Navigate(new PageUser.PageMenuUser());
                    break;
            }
        }
    }

        //Метод отключён
        //public void AuthorizationMetod()
        //{
        //    try
        //    {
        //        if (tbLogin.Text.Length > 0)
        //        {
        //            if (pbPassword.Password.Length > 0)
        //            {
        //                string UserStatus = tbLogin.Text;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Заполните поле пароля.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Заполните поле имени.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error:" + ex.Message.ToString() + "programm drop", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}
}
