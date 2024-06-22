using LostYears.Forms.Admins_Part;
using LostYears.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace LostYears.Forms.Parents_Form
{
    /// <summary>
    /// Логика взаимодействия для ParentMainWindow.xaml
    /// </summary>
    public partial class ParentMainWindow : Window
    {
        private Parent currentParent = null;
        public ParentMainWindow(string phone)
        {
            InitializeComponent();
            using (ParentContext pc = new ParentContext())
            {
                pc.Parents.Load();
                foreach (var item in pc.Parents)
                {
                    if (item.Phone == phone)
                    {
                        currentParent = new Parent() {
                            ID = item.ID,
                            Name = item.Name,
                            Surname = item.Surname,
                            Middle_Name = item.Middle_Name,
                            Phone = item.Phone,
                            WorkPlace = item.WorkPlace,
                        };
                    }
                }
            }
            this.mainFrame.Navigate(new helloPage(phone));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e) // подать заявку
        {
            this.mainFrame.Navigate(new makeApplicationPage(currentParent.ID));
        }

        private void ApplicationsButton_Click(object sender, RoutedEventArgs e) // расписание
        {
            this.mainFrame.Navigate(new schedulePage(currentParent));
        }


        private void teacherButton_Click(object sender, RoutedEventArgs e)
        {
            try { this.mainFrame.Navigate(new infoPage(((Button)sender).Tag as string ?? throw new Exception("Передана пустая ссылка"))); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
