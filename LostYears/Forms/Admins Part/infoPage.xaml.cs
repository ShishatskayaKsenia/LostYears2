using LostYears.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для infoPage.xaml
    /// </summary>
    public partial class infoPage : Page
    {
        private string type;

        DepartmentContext departmentContext;
        public infoPage(string type)
        {
            InitializeComponent();
            this.type = type;

            switch (type)
            {
                case "departmentList":
                    {
                        DataGridTextColumn column1 = new DataGridTextColumn();
                        column1.Header = "Номер";
                        column1.Binding = new Binding("ID");
                        column1.Width = new DataGridLength(1, DataGridLengthUnitType.Auto);

                        DataGridTextColumn column2 = new DataGridTextColumn();
                        column2.Header = "Имя";
                        column2.Binding = new Binding("Name");
                        column2.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column5 = new DataGridTextColumn();
                        column5.Header = "Описание";
                        column5.Binding = new Binding("Description");
                        column5.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column3 = new DataGridTextColumn();
                        column3.Header = "Инструмент";
                        column3.Binding = new Binding("Instrument_ID");
                        column3.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        // Добавляем созданные столбцы в таблицу
                        dataGrid.Columns.Add(column1);
                        dataGrid.Columns.Add(column2);
                        dataGrid.Columns.Add(column5);
                        dataGrid.Columns.Add(column3);

                        

                        using (var context = new DepartmentContext())
                        {
                            dataGrid.ItemsSource = (from department in context.Departments
                                         join instrument in context.Instruments
                                         on department.Instrument_ID equals instrument.ID
                                         select new
                                         {
                                             ID = department.ID,
                                             Name = department.Name,
                                             Description = department.Description,
                                             Instrument_ID = instrument.Name
                                         }).ToList();
                        }
                        break;
                    }
                case "studentsList":
                    {
                        DataGridTextColumn column1 = new DataGridTextColumn();
                        column1.Header = "Номер";
                        column1.Binding = new Binding("ID");
                        column1.Width = new DataGridLength(1, DataGridLengthUnitType.Auto);

                        DataGridTextColumn column2 = new DataGridTextColumn();
                        column2.Header = "Имя";
                        column2.Binding = new Binding("Name");
                        column2.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column3 = new DataGridTextColumn();
                        column3.Header = "Фамилия";
                        column3.Binding = new Binding("Surname");
                        column3.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column4 = new DataGridTextColumn();
                        column4.Header = "Отчество";
                        column4.Binding = new Binding("Middle_Name");
                        column4.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column5 = new DataGridTextColumn();
                        column5.Header = "День рождения";
                        column5.Binding = new Binding("BirthDay") {
                            StringFormat = "dd/MM/yyyy"
                        };
                        column5.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column6 = new DataGridTextColumn();
                        column6.Header = "Телефон";
                        column6.Binding = new Binding("Phone");
                        column6.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column7 = new DataGridTextColumn();
                        column7.Header = "Адрес";
                        column7.Binding = new Binding("Address");
                        column7.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column8 = new DataGridTextColumn();
                        column8.Header = "Отдел";
                        column8.Binding = new Binding("Department_ID");
                        column8.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column9 = new DataGridTextColumn();
                        column9.Header = "Родитель";
                        column9.Binding = new Binding("Parent_ID");
                        column9.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column10 = new DataGridTextColumn();
                        column10.Header = "Класс";
                        column10.Binding = new Binding("Class_ID");
                        column10.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        dataGrid.Columns.Add(column1);
                        dataGrid.Columns.Add(column2);
                        dataGrid.Columns.Add(column3);
                        dataGrid.Columns.Add(column4);
                        dataGrid.Columns.Add(column5);
                        dataGrid.Columns.Add(column6);
                        dataGrid.Columns.Add(column7);
                        dataGrid.Columns.Add(column8);
                        dataGrid.Columns.Add(column9);
                        dataGrid.Columns.Add(column10);

                        using (var context = new StudentContext())
                        {
                            dataGrid.ItemsSource = (from student in context.Student
                                                    join department in context.Departments on student.Department_ID equals department.ID
                                                    join parent in context.Parents on student.Parent_ID equals parent.ID
                                                    join Class in context.Classes on student.Class_ID equals Class.ID
                                                    select new
                                                    {
                                                        ID = student.ID,
                                                        Name = student.Name,
                                                        Surname = student.Surname,
                                                        Middle_Name = student.Middle_Name,
                                                        BirthDay = student.BirthDay,
                                                        Phone = student.Phone,
                                                        Address = student.Address,
                                                        Department_ID = department.Name,
                                                        Parent_ID = parent.Phone,
                                                        Class_ID = Class.Name,
                                                    }).ToList();
                        }
                        break;
                    }
                case "teachersList":
                    {
                        DataGridTextColumn column1 = new DataGridTextColumn();
                        column1.Header = "Номер";
                        column1.Binding = new Binding("ID");
                        column1.Width = new DataGridLength(1, DataGridLengthUnitType.Auto);

                        DataGridTextColumn column2 = new DataGridTextColumn();
                        column2.Header = "Имя";
                        column2.Binding = new Binding("Name");
                        column2.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column3 = new DataGridTextColumn();
                        column3.Header = "Фамилия";
                        column3.Binding = new Binding("Surname");
                        column3.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column4 = new DataGridTextColumn();
                        column4.Header = "Отчество";
                        column4.Binding = new Binding("Middle_Name");
                        column4.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column6 = new DataGridTextColumn();
                        column6.Header = "Телефон";
                        column6.Binding = new Binding("Phone");
                        column6.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        DataGridTextColumn column8 = new DataGridTextColumn();
                        column8.Header = "Отдел";
                        column8.Binding = new Binding("Department_ID");
                        column8.Width = new DataGridLength(1, DataGridLengthUnitType.Star);

                        dataGrid.Columns.Add(column1);
                        dataGrid.Columns.Add(column2);
                        dataGrid.Columns.Add(column3);
                        dataGrid.Columns.Add(column4);
                        dataGrid.Columns.Add(column6);
                        dataGrid.Columns.Add(column8);

                        using (var context = new TeacherContext())
                        {
                            dataGrid.ItemsSource = (from teacher in context.Teachers
                                                    join department in context.Departments on teacher.Department_ID equals department.ID
                                                    select new
                                                    {
                                                        ID = teacher.ID,
                                                        Name = teacher.Name,
                                                        Surname = teacher.Surname,
                                                        Middle_Name = teacher.Middle_Name,
                                                        Phone = teacher.Phone,
                                                        Department_ID = department.Name
                                                    }).ToList();
                        }
                        break;
                    }
            }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = (dynamic)dataGrid.SelectedItem;
            string result = "";
            switch (type)
            {
                case "departmentList":
                    {
                        result = $"Номер - {selected.ID}\nНазвание - {selected.Name}\nОписание - {selected.Description}\nИнструмент - {selected.Instrument_ID}";
                        break;
                    }
                case "studentsList":
                    {
                        result = $"Номер - {selected.ID}\nИмя - {selected.Name}\nФамилия - {selected.Surname}\nОтчество - {selected.Middle_Name}\nДень рождения - {selected.BirthDay}\nТелефон - {selected.Phone}\nАдрес - {selected.Address}\nОтделение - {selected.Department_ID}\nРодитель - {selected.Parent_ID}\nКласс - {selected.Class_ID}";
                        break;
                    }
                case "teachersList":
                    {
                        result = $"Номер - {selected.ID}\nИмя - {selected.Name}\nФамилия - {selected.Surname}\nОтчество - {selected.Middle_Name}\nТелефон - {selected.Phone}\nОтделение - {selected.Department_ID}";
                        break;
                    }
                
            }
            MessageBox.Show(result);
        }
    }
}
