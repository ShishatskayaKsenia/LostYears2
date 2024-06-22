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

namespace LostYears.Forms.Admins_Part
{
    /// <summary>
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try { this.mainFrame.Navigate(new infoPage(((Button)sender).Tag as string ?? throw new Exception("Передана пустая ссылка"))); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            try { 
                if(((Button)sender).Tag as string == "addTeacher")
                {
                    this.mainFrame.Navigate(new addTeacherPage());
                }
                else if (((Button)sender).Tag as string == "addDepartment")
                {
                    this.mainFrame.Navigate(new addDepartmentPage());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

    }
}
