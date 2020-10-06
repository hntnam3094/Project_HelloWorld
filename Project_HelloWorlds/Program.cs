using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =  UpperCase("hello Worlds");
            Console.WriteLine(text);
            Console.ReadKey();
        }

        static string UpperCase(string text)
        {
            return text.ToUpper();

        }
    }
}
