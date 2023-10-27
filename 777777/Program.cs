using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777777
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "12rt ojt c45";
            foreach (char c in str)
            {
                if ( Char.IsDigit(c))
                {
                    str = str.Replace(c, 'i');
                }
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
