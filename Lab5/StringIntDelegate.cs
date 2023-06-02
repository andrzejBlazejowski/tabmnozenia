using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public delegate string StringIntDelegate(string str, int num);

    public class DelegationExample
    {
        public static string AppendNumber(string str, int num)
        {
            return str + num.ToString();
        }

        public static string RepeatString(string str, int num)
        {
            return string.Concat(Enumerable.Repeat(str, num));
        }

        public static string GetSubstring(string str, int num)
        {
            if (num <= str.Length)
            {
                return str.Substring(0, num);
            }
            return str;
        }
    }
}
