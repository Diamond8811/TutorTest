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
using TutorTest.Pages;
using TutorTest.Connection;

namespace TutorTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для AvtorizationPages.xaml
    /// </summary>
    public partial class AvtorizationPages : Page
    {
        
        public AvtorizationPages()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            var user = Connection.Connection.db.User.ToList().Find(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text);
            if (user != null)
            {

            }
            else 
            {
                MessageBox.Show("Логин или пароль неверный!");
            }

        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
