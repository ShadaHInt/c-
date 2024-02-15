using System;
namespace Testing
{
    class Test
    {
        string name;
        public Test()
        {
            name = "shada";
        }
        public static void Main(string[] args)
        {
            //Test test = new Test();
            //Console.WriteLine(test.name);
            //Method("shada");
            //Console.Write(Method1(3));
            //EvenOdd();
            //Sum();
            //Factorial();
            StringL();

            Test obj = new Test();



        }
        static void Method(string name)
        {
            Console.WriteLine(name + "sss");

        }

        static int Method1(int x)
        {
            return x;
        }

        static void EvenOdd()
        {
            int num;
            Console.WriteLine("enter a number");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }

        static void Sum()
        {
            int sum = 0, temp = 0, num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                temp = num % 10;
                num = num / 10;
                sum = sum + temp;

            }
            Console.WriteLine(sum);

        }

        static void Factorial()
        {
            int fact = 1, i, num;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("no");

            }
            else if (num == 0)
            {
                Console.WriteLine("factorial 1");
            }
            else
            {
                for (i = num; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);
            }
        }

        static void StringL()
        {
            Console.WriteLine("enter string");
            string x = Console.ReadLine();
            Console.WriteLine(x.Length);
        }


    }
}
