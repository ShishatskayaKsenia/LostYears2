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

namespace LostYears.Forms.Teachers_Part
{
    /// <summary>
    /// Логика взаимодействия для TeachersMainWindow.xaml
    /// </summary>
    public partial class TeachersMainWindow : Window
    {
        public TeachersMainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // рассмотрение заявок
        {
            this.mainFrame.Navigate(new newEntriesPage());
        }

        private void teacherButton_Click(object sender, RoutedEventArgs e) // классы
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
