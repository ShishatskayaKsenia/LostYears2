using LostYears.Models;
using Microsoft.Win32;
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
    /// Логика взаимодействия для addDepartmentPage.xaml
    /// </summary>
    public partial class addDepartmentPage : Page
    {
        string imagePath;
        public addDepartmentPage()
        {
            InitializeComponent();

            using (InstrumentContext dc = new InstrumentContext()) {
                foreach(var item in dc.Instruments)
                {
                    instrumentCB.Items.Add($"{item.ID} - {item.Name}");
                }
            }
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            string[] insts = instrumentCB.SelectedItem.ToString().Split('-');
            int I_ID = int.Parse(insts[0]), D_ID;
            using (DepartmentContext dc = new DepartmentContext())
            {
                D_ID = dc.Departments.Max(d => d.ID) + 1;
            }
            Department current = new Department() {
                ID = D_ID,
                Name = nameTB.Text,
                ImagePath = imagePath,
                Description = descriptionTB.Text,
                Instrument_ID = I_ID
            };
            string name = nameTB.Text;
            string description = descriptionTB.Text;

            using (DepartmentContext dc = new DepartmentContext())
            {
                dc.Departments.Add(current);
                dc.SaveChanges();
            }
        }

        private void selectImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath);
                bitmap.EndInit();

                imageFrame.Source = bitmap;
            }
        }
    }
}
