using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 stol = new Class1(30, 15, "красный", "Дерево", "Квадрат");
            Console.WriteLine(Class1.ReturnForm());
            Console.ReadLine();
        }
    }
}
