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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LostYears.Forms.Parents_Form
{
	/// <summary>
	/// Логика взаимодействия для schedulePage.xaml
	/// </summary>
	public partial class schedulePage : Page
	{
		Parent currentParent = null;
		int currentClassID;
		public schedulePage(Parent parent)
		{
			InitializeComponent();
			this.currentParent = parent;

			List<int> classes = new List<int>();
			using (StudentContext sc = new StudentContext())
			{
				foreach(var item in sc.Student)
				{
					if(item.Parent_ID == currentParent.ID)
					{
						classes.Add(item.Class_ID);
					}
				}
			}
			using (ClassContext cc = new ClassContext())
			{
				foreach (var item in cc.Classes.ToList())
				{
					foreach(var class_id in classes)
					{
						if(item.ID == class_id)
						{
							try { classTB.Items.Add($"{class_id} - {item.Name}"); }
							catch(Exception ex) { MessageBox.Show(ex.ToString()); }
                            /*
							 System.Data.SqlClient.SqlException: "A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)"
							 */
                        }
                    }
				}
			}
		}

		private void classTB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			/*
			 09.00 - 10.00
			 10.20 - 11.20
			 11.40 - 12.40
			 13.00 - 14.00
			 */
			SchedulesContext sc = new SchedulesContext();
			LessonsContext lc = new LessonsContext();

			try
			{
				this.currentClassID = int.Parse(classTB.SelectedItem.ToString().Split('-')[0]);

				sc.Schedules.Load();
				var sc_ = sc.Schedules.ToList();
                sc.Dispose();

                lc.Lessons.Load();
				var lc_ = lc.Lessons.ToList();
                lc.Dispose();

                foreach (var item in sc_)
				{
					if (item.Class_ID == currentClassID)
					{
						Lesson lesson = lc_.First(e => e.ID == item.Lesson_ID);

						int scheduleGridRow = 1, scheduleGridColumn = 1;
						switch (item.start_time.Hours)
						{
							case 9:
								{
									scheduleGridRow = 1;
									break;
								}
							case 10:
								{
									scheduleGridRow = 2;
									break;
								}
							case 11:
								{
									scheduleGridRow = 3;
									break;
								}
							case 13:
								{
									scheduleGridRow = 4;
									break;
								}
						}
						switch (item.date.DayOfWeek)
						{
							case DayOfWeek.Monday:
								{
									scheduleGridColumn = 1;
									break;
								}
							case DayOfWeek.Tuesday:
								{
									scheduleGridColumn = 2;
									break;
								}
							case DayOfWeek.Wednesday:
								{
									scheduleGridColumn = 3;
									break;
								}
							case DayOfWeek.Thursday:
								{
									scheduleGridColumn = 4;
									break;
								}
							case DayOfWeek.Friday:
								{
									scheduleGridColumn = 5;
									break;
								}
						}
						Grid grid = new Grid() {
							RowDefinitions = {
								new RowDefinition(),
								new RowDefinition()
							},
							Children =
							{
								new TextBlock()
								{
									Text = lesson.Name,
									FontSize = 20,
									TextWrapping = TextWrapping.Wrap
								}
							}
						};

						Grid.SetRow(grid, scheduleGridRow); // Указываем целевую строку
						Grid.SetColumn(grid, scheduleGridColumn); // Указываем целевой столбец

						scheduleGrid.Children.Add(grid);
					}
				}
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}
