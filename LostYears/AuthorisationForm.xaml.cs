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

namespace LostYears
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationForm.xaml
    /// </summary>
    public partial class AuthorisationForm : Window
    {
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            Forms.Teachers_Part.TeachersMainWindow teachers = new Forms.Teachers_Part.TeachersMainWindow();
            teachers.Show();
            this.Close();
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            Forms.Admins_Part.AdminMainWindow admin = new Forms.Admins_Part.AdminMainWindow();
            admin.Show();
            this.Close();
        }

        private void studentButton_Click(object sender, RoutedEventArgs e)
        {
            Forms.Parents_Form.ParentMainWindow parentMain = new Forms.Parents_Form.ParentMainWindow(loginTB.Text);
            parentMain.Show();
            this.Close();
        }
    }
}
