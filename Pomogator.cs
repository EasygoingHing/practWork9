using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Практическая9
{
    internal class Pomogator
    {
        /// <summary>
        /// Реализует работу с радиокнопками.
        /// </summary>
        /// <param name="fullname">Строка</param>
        /// <param name="gender">Строка</param>
        /// <param name="yearOfBirth">Целое число</param>
        /// <param name="placeOfBirth">Строка</param>
        /// <param name="nationality">Строка</param>
        /// <param name="questionnaire">Список для записи.</param>
        /// <param name="radioButtons">Радиокнопки.</param>

        public static void IsRadioButtonChecked(string fullname, string gender, int yearOfBirth, string placeOfBirth, string nationality, List<DataQuestionnaire> questionnaire, params RadioButton[] radioButtons)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if ((bool)radioButtons[i].IsChecked)
                {
                    questionnaire[i] = new DataQuestionnaire
                    {
                        Fullname = fullname,
                        Gender = gender,
                        YearOfBirth = yearOfBirth,
                        PlaceOfBirth = placeOfBirth,
                        Nationality = nationality
                    };
                    break;
                }
            }
        }
    }
}
