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

namespace LostYears.Forms.Parents_Form
{
    /// <summary>
    /// Логика взаимодействия для makeApplicationPage.xaml
    /// </summary>
    public partial class makeApplicationPage : Page
    {
        private int P_ID;
        public makeApplicationPage(int parent_ID)
        {
            InitializeComponent();
            this.P_ID = parent_ID;

            using (DepartmentContext dc = new DepartmentContext())
            {
                foreach(var item in dc.Departments.ToList())
                {
                    departmentCB.Items.Add($"{item.ID} - {item.Name}");
                }
            }
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (ChildrenEntryContext cec = new ChildrenEntryContext())
                {
                    ChildrenEntry entry = new ChildrenEntry()
                    {
                        ID = cec.ChildrenEntries.Max(x => x.ID) + 1,
                        Name = nameTB.Text,
                        Surname = surnameTB.Text,
                        Middle_Name = midnameTB.Text,
                        BirthDay = DateTime.Parse(birthdayDP.Text),
                        Phone = phoneTB.Text,
                        Address = addressTB.Text,
                        Department_ID = int.Parse(departmentCB.SelectedItem.ToString().Split('-')[0]),
                        Parent_ID = P_ID
                    };
                    cec.ChildrenEntries.Add(entry);
                    cec.SaveChanges();
                }
                MessageBox.Show("Ваша заявка отправлена!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void departmentCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int D_ID = int.Parse(departmentCB.SelectedItem.ToString().Split('-')[0]);
                using (DepartmentContext dc = new DepartmentContext())
                {
                    foreach(var item in dc.Departments.ToList())
                    {
                        if(item.ID == D_ID)
                        {
                            BitmapImage bitmap = new BitmapImage();
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(item.ImagePath);
                            bitmap.EndInit();

                            imageFrame.Source = bitmap;
                            //
                            //using (InstrumentContext ic = new InstrumentContext())
                            //{
                            //    foreach(var item2 in ic.Instruments.ToList())
                            //    {
                            //        if(item2.ID == item.Instrument_ID)
                            //        {

                            //        }
                            //    }
                            //}
                            //item.Instrument.
                            nameDepartmentTB.Text = item.Name;
                            instrumentDepartmentTB.Text = item.Instrument.Name;
                            descriptionDepartmentTB.Text = item.Description;
                            
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
