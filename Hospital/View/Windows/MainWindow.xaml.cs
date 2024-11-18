using Hospital.AppData;
using Hospital.View.Windows;
using System.Windows;

namespace Hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHepler.mainFrame = MainFrame;
            FullnameTbl.Text = AuthorizationHelper.currentDoctor.Surname + " " + AuthorizationHelper.currentDoctor.Name + " " + AuthorizationHelper.currentDoctor.Patronymic;
        }

        private void PatientBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.PatientPage());
        }

        private void SheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.ShedulePage());
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.Show();
        }

        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }
    }
}
