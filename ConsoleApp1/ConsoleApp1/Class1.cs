using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        string colour = "red";
        static void Main (string[] args)
            {
            Class1 Obj = new Class1();
            Obj.Print();

            }
        public  Print()
        {
            Console.WriteLine(colour);
        }
    }
}
