using System;

namespace DataTransferObjects
{
    public class EnumHelper
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static string GetBloodName(string value)
        {
            int i = 0, a = 0;
            foreach (var ch in value)
            {
                if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')))
                {
                    if (ch == '+')
                    {
                        a = 1;
                    }
                    else if (ch == '-')
                    {
                        a = 2;
                    }
                    break;
                }
                i++;
            }
            string newStr = "";
            for (int j = 0; j < i; j++)
            {
                newStr += value[j];
            }
            if (a == 1)
            {
                return newStr + "pos";
            }
            else
            {
                return newStr + "neg";
            }
        }
    }
}
