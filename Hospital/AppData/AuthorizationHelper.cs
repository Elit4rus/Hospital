using Hospital.Model;
using System.Linq;
using System.Windows;

namespace Hospital.AppData
{
    internal class AuthorizationHelper
    {
        public static Doctor currentDoctor;
        public static bool CheckData(string login, string password)
        {
            currentDoctor = App.context.Doctor.FirstOrDefault(d => d.Login == login && d.Password == password);
            if (currentDoctor != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                return false;
            }


        }
    }
}
