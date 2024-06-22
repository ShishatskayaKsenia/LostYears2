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

namespace LostYears.Forms.Admins_Part
{
    /// <summary>
    /// Логика взаимодействия для addTeacherPage.xaml
    /// </summary>
    public partial class addTeacherPage : Page
    {
        public addTeacherPage()
        {
            InitializeComponent();

            using (DepartmentContext dc = new DepartmentContext())
            {
                foreach (var item in dc.Departments)
                {
                    departmentCB.Items.Add($"{item.ID} - {item.Name}");
                }
            }
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            using (TeacherContext tc = new TeacherContext()) { 
                string name = nameTB.Text, surname = surnameTB.Text, midname = midnameTB.Text, phone = phoneTB.Text;
                int D_ID = int.Parse(departmentCB.SelectedItem.ToString().Split('-')[0]),
                    T_ID = tc.Teachers.Max(d => d.ID) + 1;
                
                tc.Teachers.Add(new Teacher()
                {
                    ID = T_ID,
                    Name = name,
                    Surname = surname,
                    Middle_Name = midname,
                    Phone = phone,
                    Department_ID = D_ID,
                });
                tc.SaveChanges();
            }
            MessageBox.Show("Учитель добавлен!");
        }
    }
}
