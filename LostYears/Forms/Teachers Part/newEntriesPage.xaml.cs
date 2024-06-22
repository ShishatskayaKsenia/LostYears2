using LostYears.Models;
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

namespace LostYears.Forms.Teachers_Part
{
    /// <summary>
    /// Логика взаимодействия для newEntriesPage.xaml
    /// </summary>
    public partial class newEntriesPage : Page
    {
        public newEntriesPage()
        {
            InitializeComponent();
            using (ChildrenEntryContext cec = new ChildrenEntryContext())
            {
                foreach(var item in cec.ChildrenEntries.ToList())
                {
                    entriesLB.Items.Add($"{item.ID} - {item.Surname} {item.Name}");
                }
            }
        }

        private void selectImageButton_Click(object sender, RoutedEventArgs e) // отклонить
        {
            
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e) // принять
        {

        }

        private void entriesLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                int ID = int.Parse(entriesLB.SelectedItem.ToString().Split('-')[0]), P_ID = 0, D_ID = 0;
                using (ChildrenEntryContext cec = new ChildrenEntryContext())
                {
                    foreach(var item in cec.ChildrenEntries.ToList())
                    {
                        if(item.ID == ID)
                        {
                            nameTB.Text = item.Name;
                            surnameTB.Text = item.Surname;
                            midnameTB.Text = item.Middle_Name;
                            birthdaynameTB.Text = $"{item.BirthDay:d}";
                            phoneTB.Text = item.Phone;
                            addressTB.Text = item.Address;
                            P_ID = item.Parent_ID;
                            D_ID = item.Department_ID;
                        }
                    }
                }

                using (DepartmentContext context = new DepartmentContext())
                {
                    foreach(var item in context.Departments)
                    {
                        if(item.ID == D_ID)
                        {
                            departmentTB.Text = item.Name;
                        }
                    }
                }
                using (ParentContext context = new ParentContext())
                {
                    foreach(var item in context.Parents)
                    {
                        if(item.ID == D_ID)
                        {
                            parentTB.Text = $"{item.Surname} {item.Name}. {item.Middle_Name}.";
                        }
                    }
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
