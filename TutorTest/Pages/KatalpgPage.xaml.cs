using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using TutorTest.Connection;

namespace TutorTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для KatalpgPage.xaml
    /// </summary>
    public partial class KatalpgPage : Page
    {

        public ObservableCollection<Service> Services { get; set; }
        public KatalpgPage()
        {
            InitializeComponent();
            LoadServices();
            ServicesItemsControl.ItemsSource = Services;
        }

        private void LoadServices()
        {
            // Загружаем все услуги из базы данных (используем статический класс Connection)
            var dbServices = Connection.Connection.db.Service.ToList();


            Services = new ObservableCollection<Service>(dbServices);
        }





    }
}
