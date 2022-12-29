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
    /// Логика взаимодействия для eventPage.xaml
    /// </summary>
    public partial class eventPage : Page
    {
        public eventPage()
        {
            InitializeComponent();
            var currentEvent = RibichenkoEntities.GetContext().@event.ToList();
            DG.ItemsSource = currentEvent;
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var materialsForRemoving = DG.SelectedItems.Cast<@event>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {materialsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RibichenkoEntities.GetContext().@event.RemoveRange(materialsForRemoving);
                    RibichenkoEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DG.ItemsSource = RibichenkoEntities.GetContext().@event.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
