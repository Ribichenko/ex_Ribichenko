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
using System.Windows.Shapes;

namespace ex_Ribichenko
{
    /// <summary>
    /// Логика взаимодействия для loginWin.xaml
    /// </summary>
    public partial class loginWin : Window
    {
        public loginWin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            moderator selectModerator = (sender as Button).DataContext as moderator;
            organizer selectOrganizer = (sender as Button).DataContext as organizer;
            jury selectJury = (sender as Button).DataContext as jury;
            member selectMember = (sender as Button).DataContext as member;
            bool log = false;
            foreach (var a in RibichenkoEntities.GetContext().organizer)
            {
                if (login.Text == a.email)
                {
                    log = true;
                    if (pass.Text == a.password)
                    {
                        MessageBox.Show("Успешная авторизация");
                        ShowMain();
                        Close();
                    }
                }
            }
            if (log == false)
            {
                MessageBox.Show("Неверный логин");
            }
        }

        public void ShowMain()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
