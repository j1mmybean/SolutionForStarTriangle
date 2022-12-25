using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ComponentDep.ComsoleApp
{
    internal class OutputTriangle
    {
        static void Main(string[] args)
        {

            const int c = 5;
            string result = string.Empty;
            string x = string.Empty;
            for (int i = 0; i < c; i++)
            {
                x += "*";
                result += x;
                Console.WriteLine(string.Format("{0,5}", x));     //輸出靠右三角
            }

            result = string.Empty;
            string y = string.Empty;
            for (int i = 0; i < c; i++)
            {
                y += "*";
                result += y + "\n";
            }
            Console.WriteLine(result); //輸出靠左三角

            result = string.Empty;
            string z = "*";
            for (int i = 0; i < c; i++)
            {
                result += new string(' ', c-i) + new string('*', 2*i+1) + "\n";
            }
            Console.WriteLine(result); //輸出置中三角

            Console.ReadLine();


        }
    }
}
