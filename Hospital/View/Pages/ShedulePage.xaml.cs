using Hospital.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hospital.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShedulePage.xaml
    /// </summary>
    public partial class ShedulePage : Page
    {
        List<Area> areas = App.context.Area.ToList();
        public ShedulePage()
        {
            InitializeComponent();
            SheduleLv.ItemsSource = areas;
        }
    }
}
