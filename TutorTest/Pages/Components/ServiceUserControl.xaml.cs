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
using TutorTest.Connection;

namespace TutorTest.Pages.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        Service service;
        public ServiceUserControl(Service _service)
        {
            InitializeComponent();
            service = _service;
            this.DataContext = _service;
            //TitleTb.Text = service.Title;
            if (AvtorizationPages.autorizedUser.RoleID != 1)
            {
                EditBtn.Visibility = Visibility.Collapsed;
                DeleteBtn.Visibility = Visibility.Collapsed;
            }
        }
    }
}
