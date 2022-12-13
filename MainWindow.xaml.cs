using System;
using System.Collections.Generic;
using System.Windows;
using Пример_таблицы_WPF;

namespace Практическая9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = questionnaire.ToDataTable().DefaultView;
        }

        List<DataQuestionnaire> questionnaire = new List<DataQuestionnaire>()
        {
            new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
            new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
            new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
            new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
            new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"}
        };

        private void FillExample_Click(object sender, RoutedEventArgs e)
        {
            questionnaire = new List<DataQuestionnaire>()

            {
                new DataQuestionnaire { Fullname = "Крутолапов Валерий Романович", Gender = "М", YearOfBirth = 2004, PlaceOfBirth = "Рязань",  Nationality = "Русский" },
                new DataQuestionnaire { Fullname = "Крюкова Ева Александровна", Gender = "Ж", YearOfBirth = 2000, PlaceOfBirth = "Самара" , Nationality = "Русская" },
                new DataQuestionnaire { Fullname = "Гурова Мия Макаровна", Gender = "Ж", YearOfBirth = 2005, PlaceOfBirth = "Москва", Nationality = "Украинка" },
                new DataQuestionnaire { Fullname = "Новиков Марк Даниилович", Gender = "М", YearOfBirth = 1999, PlaceOfBirth = "Лос - Анджелес",  Nationality = "Американец" },
                new DataQuestionnaire { Fullname = "Винокуров Захар Макарович", Gender = "М", YearOfBirth = 2010, PlaceOfBirth = "Берлин", Nationality = "Немец" }
            };

            dataGrid.ItemsSource = questionnaire.ToDataTable().DefaultView;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {            
            try
            {
                int yearOfBirth = int.Parse(tbYearOfBirth.Text);

                string name = tbFullname.Text;
                string gender = tbGender.Text;
                string placeOfBirth = tbPlaceOfBirth.Text;
                string nationality = tbNationality.Text;

                Pomogator.IsRadioButtonChecked(name, gender, yearOfBirth, placeOfBirth, nationality, questionnaire, RBfirst, RBsecond, RBthird, RBfourth, RBfifth);
            }
            catch (Exception)
            {
                MessageBox.Show("Указаны не все данные или неверный формат");
            }            

            dataGrid.ItemsSource = questionnaire.ToDataTable().DefaultView;
        }        

        private void Сlear_Click(object sender, RoutedEventArgs e)
        {
            questionnaire = new List<DataQuestionnaire>()
            {
                new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
                new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
                new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
                new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"},
                new DataQuestionnaire { Fullname = "0", Gender = "0", YearOfBirth = 0, PlaceOfBirth = "0", Nationality = "0"}
            };

            dataGrid.ItemsSource = questionnaire.ToDataTable().DefaultView;
        }

        private void AvgAge_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0,
                kol = 0;
            
            foreach (var item in questionnaire)
            {
                if (item.YearOfBirth <= 0)
                {
                    continue;
                }
                else
                {                    
                    sum += DateTime.Now.Year - item.YearOfBirth;
                    kol++;
                }               
            }
            tbAvgAge.Text += Math.Round((float)sum / kol );
        }
    }
}
