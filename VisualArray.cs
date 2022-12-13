using System.Collections.Generic;
using System.Data;
using Практическая9;

namespace Пример_таблицы_WPF
{
    //Класс для визуализации данных на DataGrid.
    static class VisualArray
    {
        /// <summary>
        /// Реализует визуализацию даннных на DataGrid из передаваемого списка структуры QuestionnaireList.
        /// </summary>
        /// <param name="list">Список содержащий экземпляры структуры QuestionnaireList.</param>
        /// <returns>Представление таблицы.</returns>
        public static DataTable ToDataTable(this List<DataQuestionnaire> questionnaire)
        {
            var DataGrid = new DataTable();

            DataGrid.Columns.Add("Номер", typeof(int));
            DataGrid.Columns.Add("ФИО", typeof(string));
            DataGrid.Columns.Add("Пол", typeof(string));
            DataGrid.Columns.Add("Год рождения", typeof(int));
            DataGrid.Columns.Add("Место рождения", typeof(string));
            DataGrid.Columns.Add("Национальность", typeof(string));

            DataGrid.Columns[0].AutoIncrementSeed = 1;
            DataGrid.Columns[0].AutoIncrement = true;

            for (int i = 0; i < questionnaire.Count; i++)
            {
                DataRow row = DataGrid.NewRow();

                row[1] = questionnaire[i].Fullname;
                row[2] = questionnaire[i].Gender;
                row[3] = questionnaire[i].YearOfBirth;
                row[4] = questionnaire[i].PlaceOfBirth;
                row[5] = questionnaire[i].Nationality;

                DataGrid.Rows.Add(row);
            }

            return DataGrid;
        }
    }
}
