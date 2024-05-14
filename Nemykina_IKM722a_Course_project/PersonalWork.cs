using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemykina_IKM722a_Course_project
{
    internal class PersonalWork
    {
        public static char Letters(char c)
        {
            string vowels = "аоуеиiяюэ";

            foreach (char ch in vowels)
            {
                if (c == ch)
                {
                    return '*';
                }
            }

            return c;
        }

        public static string Rphrase(string str)
        {
            if (str[str.Length - 1] == '.')
            {
                char[] result = new char[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    result[i] = Letters(str[i]);
                }

                return new string(result.Reverse().ToArray());
            }
            else
            {
                return str;
            }
        }
    }
}
