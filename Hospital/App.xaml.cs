using Hospital.Model;
using System.Windows;

namespace Hospital
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HospitalEntities context = new HospitalEntities();
    }
}
