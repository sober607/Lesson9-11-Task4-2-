using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    extern alias Lesson1;
    class Program
    {
        static void Main(string[] args)
        {
            Lesson1.Lesson9_11_Task4_2_.Class1 externalClass = new Lesson1.Lesson9_11_Task4_2_.Class1();
            externalClass.MyMethod();
            Console.ReadLine();
        }
    }
}
