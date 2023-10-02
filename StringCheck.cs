using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrargz
{
    public class StringCheck
    {
        /// <summary>
        /// В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. Текст может включать в себя произвольные символы.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>
        /// Возвращается список символов List<char>. Список должен содержать буквы искомого текста и удовлетворять требованиям, указанным выше.
        /// </returns>
        public static List<char> GetLetters(string textString)
        {
            List<char> list = new List<char>();

            string letters = new string(textString.Where(Char.IsLetter).ToArray());

            char[] chars = letters.ToCharArray();

            foreach (char item in chars)
            {
                list.Add(Char.ToUpper(item));
            }

            list = list.Distinct().ToList();

            list.Sort();


            return list;
        }





    }
}
