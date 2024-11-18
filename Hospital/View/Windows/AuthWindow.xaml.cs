using Hospital.AppData;
using System.Windows;

namespace Hospital.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationHelper.CheckData(NumberTb.Text, PasswordTb.Text) == true)
            {
                Close();
            }
        }
    }
}
