using Hospital.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Hospital.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        List<Card> cards = App.context.Card.ToList();
        List<Category> categories = App.context.Category.ToList();
        public PatientPage()
        {
            InitializeComponent();
            categories.Insert(0, new Category() { Title = "Все врачи" });
            PatientLv.ItemsSource = cards;
            DoctorCmb.ItemsSource = categories;
        }

        private void DoctorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Doctor selectedDoctor = DoctorCmb.SelectedItem as Doctor;
            if (DoctorCmb.SelectedIndex == 0)
            {
                PatientLv.ItemsSource = cards;
            }
            else
            {
                PatientLv.ItemsSource = cards.Where(c => c.DoctorID == DoctorCmb.SelectedIndex).ToList();
            }
        }
    }
}
