using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseLibrary
{

    public class StringReversClass
    {
        /// <summary>
        /// Создание слова-Перевертыша "в нижнем регистре"
        /// </summary>
        /// <param name="textString">В качестве параметра передается строка, представляющая одно слово и содержащая ноль или более символов.</param>
        /// <returns>Возвращается “перевернутая” строка, в которой последний символ станет первым, предпоследний вторым и т. д. Все символы возвращаются в нижнем регистре</returns>
        public string ReverseString(string textString)
        {
            if (textString.Length>=1)
            {
                textString = textString.ToLower();
                char[] slovo = textString.ToCharArray();
                Array.Reverse(slovo);
                return String.Join("",slovo);
            }
            else { throw new Exception(); }

        }
        public static bool IsPalindrome(string textString)
        {
            string textString2 = new StringReversClass().ReverseString(textString);
            if ()
            {
                return false;
            }
            return true;
        }
    }
}
