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
using TutorTest.Pages.Components;

namespace TutorTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
            foreach (var servive in Connection.Connection.db.Service.ToList())
            {
                ServiceWp.Children.Add(new ServiceUserControl(servive));
            }
        }
    }
}
