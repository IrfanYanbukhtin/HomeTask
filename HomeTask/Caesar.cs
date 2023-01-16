using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_
{
    internal class Caesar
    {
        public static string CaesarDecode (int k, string v) 
        {
            Console.WriteLine("How many scrolls into left");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert Letter or Word: ");
            string s = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 - a) % 26 + 64;

                    if (b <= 64)
                        b = b + 26;

                    result += (char)b;
                }

                else
                {
                    int c = (s[i] - 96 - a) % 26 + 96;

                    if(c <= 96)
                        c = c + 26;

                    result += (char)c;
                }
            }

            return result;
        }

        
    }
}
