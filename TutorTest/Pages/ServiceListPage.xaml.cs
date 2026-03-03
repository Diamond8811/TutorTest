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
            if (AvtorizationPages.autorizedUser.RoleID != 1)
            {
                
            }
            foreach (var servive in Connection.Connection.db.Service.ToList())
            {
                ServiceWp.Children.Add(new ServiceUserControl(servive));
            }
        }
        private void UpdateListServices()
        {
            var services = Connection.Connection.db.Service.ToList();
            if (SortCb.SelectedIndex > 0)
            {
                if (SortCb.SelectedIndex == 1)
                {
                    services = services.OrderBy(x => x.CostOfDiscount).ToList();
                }
                else if (SortCb.SelectedIndex == 2)
                {
                    services = services.OrderByDescending(x => x.CostOfDiscount).ToList();
                }
            }
            ServiceWp.Children.Clear();
            foreach (var servive in Connection.Connection.db.Service.ToList())
            {
                ServiceWp.Children.Add(new ServiceUserControl(servive));
            }
        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListServices();
        }
    }
}
