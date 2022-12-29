using ex_Ribichenko.AppDataFile;
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

namespace ex_Ribichenko.pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        public @event _currentEvent = new @event();
        public AddEditPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();
            if (titleTB.Text.Length < 1)
            {
                errors.AppendLine("Укажите название");
            }
            if (days.Text.Length < 1)
            {

                errors.AppendLine("Укажите количество дней");
            }

            if (datePicker1.DisplayDate < DateTime.Now.Date)
            {
                errors.AppendLine("Дата должна быть не раньше сегодня");
            }

            if (organizer.Text.Length < 1)
            {
                errors.AppendLine("Укажите организатора");
            }
            if (moderator.Text.Length < 1)
            {
                errors.AppendLine("Укажите модератора");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {

            }

            if (_currentEvent.id == 0)
            {
                //titleTB.Text = _currentEvent.name;
                //days.SelectedItem = _currentEvent.day;
                //datePicker1.SelectedDate = _currentEvent.date;
                //countries.SelectedItem = _currentEvent.country;
                //organizer.SelectedItem = _currentEvent.organizer;
                //moderator.SelectedItem = _currentEvent.moderator;
                //jury.SelectedItem = _currentEvent.jury;

                RibichenkoEntities.GetContext().@event.Add(_currentEvent);

            }
            try
            {
                titleTB.Text = _currentEvent.name;
                days.SelectedItem = _currentEvent.day;
                datePicker1.SelectedDate = _currentEvent.date;
                countries.SelectedItem = _currentEvent.country;
                organizer.SelectedItem = _currentEvent.organizer;
                moderator.SelectedItem = _currentEvent.moderator;
                jury.SelectedItem = _currentEvent.jury;
                RibichenkoEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new eventPage());
        }
    }
}
