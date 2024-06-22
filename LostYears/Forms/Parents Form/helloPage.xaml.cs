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
    /// Логика взаимодействия для helloPage.xaml
    /// </summary>
    public partial class helloPage : Page
    {
        public helloPage(string phone)
        {
            InitializeComponent();
            string FirstName = "", LastName = "";
            using (ParentContext pc = new ParentContext())
            {
                //var list = pc.Parents.Where(p => p.Phone.Trim() == phone).ToList();
                pc.Parents.Load();
                foreach (var item in pc.Parents)
                {
                    if(item.Phone == phone)
                    {
                        FirstName= item.Name;
                        LastName = item.Surname;
                    }
                }
            }
            TB1.Text = $"Здравствуйте, {FirstName} {LastName}!";
            TB2.Text = $"Добро пожаловать в Музыкальную Школу \"Lost years\"!.";
            TB3.Text = $"Мы рады приветствовать вас в нашем музыкальном сообществе, где каждый найдет для себя место, будь то начинающий музыкант или опытный исполнитель. В нашей школе царит атмосфера творчества и вдохновения, которая помогает каждому ученику раскрыть свои таланты и достичь высот в музыкальном искусстве.\n" +
                       $"\nНаши преподаватели — это профессионалы с многолетним опытом, которые готовы делиться своими знаниями и любовью к музыке. Мы предлагаем разнообразные курсы по обучению игре на различных инструментах, вокалу, теории музыки и многому другому. Независимо от вашего возраста и уровня подготовки, у нас вы найдете программу, соответствующую вашим интересам и целям.\n" +
                       $"\nМузыкальная Школа \"Lost years\" — это не просто учебное заведение, это место, где рождается дружба и растет взаимопонимание. Мы организуем концерты, мастер-классы и фестивали, где вы сможете продемонстрировать свои достижения и насладиться выступлениями других.\n" +
                       $"\nПрисоединяйтесь к нам и начните свое музыкальное путешествие уже сегодня. Пусть музыка станет вашим верным спутником и источником радости!";
        }
    }
}
