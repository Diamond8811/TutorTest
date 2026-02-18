using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using TutorTest.Connection;

namespace TutorTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            GenderCb.ItemsSource = Connection.Connection.db.Gender.ToList();
            GenderCb.DisplayMemberPath = "Name";

        }

        private void Cansel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Regbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(LastName.Text) || string.IsNullOrWhiteSpace(Patronymic.Text) ||
                string.IsNullOrWhiteSpace(LoginTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text) || GenderCb.SelectedItem != null
                || BirthDay.SelectedDate != null)
            {
                if (Connection.Connection.db.User.ToList().Any(x => x.Login == LoginTb.Text))
                {
                    MessageBox.Show("Логин занят");
                }
                else if (PasswordTb.Text.Length < 6 || !Regex.IsMatch(PasswordTb.Text, "[A-Z]") || !Regex.IsMatch(PasswordTb.Text, "[0-9]") || !Regex.IsMatch(PasswordTb.Text, "[0-9]"))
                {
                    MessageBox.Show("*\tМнимум 6 символов.\r\n*Минимум один символ верхнего регистра");
                }
                else if (!EmailTb.Text.EndsWith("@mail.ru") || !EmailTb.Text.EndsWith("@gmail.ru"))
                {
                    MessageBox.Show("Неправильно введена почта");
                }
                else
                {
                    var user = Connection.Connection.db.User.Add(new Connection.User()
                    {
                        Login = LoginTb.Text,
                        Password = PasswordTb.Text,
                        RoleID = 2
                    });
                    Connection.Connection.db.Client.Add(new Client()
                    {
                        FirstName = FirstName.Text,
                        LastName = LastName.Text,
                        Patronymic = Patronymic.Text,
                        RegistrationDate = DateTime.Now,
                        Birthday = BirthDay.SelectedDate,
                        Email = EmailTb.Text,
                        Phone = Phone.Text,
                        UserID = user.ID,
                        GenderID = (GenderCb.SelectedItem as Gender).ID
                    }
                    );
                    Connection.Connection.db.SaveChanges();


                    MessageBox.Show("Вы зарегались");
                }
                    
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
            
            
        }
    }
}
