using System;

namespace BasicProgramming
{
    class Program
    {
        static void MyDefaultParameter(int x= 2)
        {
            Console.WriteLine($"My parameter is : {x}");
        }
        static void Main(string[] args)
        {
            //Type Casting
            //Implicit Type casting float -> double
            Console.WriteLine("Implicit Type casting float -> double");
            float floatNum = 12.3F;
            double doubleNum = floatNum;
            Console.WriteLine(doubleNum);
            //Explicit Type casting double -> int
            Console.WriteLine("Explicit Type casting double -> int ");
            int intNum = (Int32)doubleNum;
            Console.WriteLine(intNum);
            Console.WriteLine("\n");

            //Bitwise And(&) operator
            Console.WriteLine("Bitwise And(&) operator: 4 & 12 = ");
            Console.WriteLine(4 & Convert.ToInt32(floatNum));
            Console.WriteLine("\n");

            //Logical OR(||) operator
            Console.WriteLine("Logical OR(||) operator");
            Console.WriteLine(4> 11 || 3>2);
            Console.WriteLine("\n");

            /*String Interopolation:
              substitutes values of variables into placeholders */
            Console.WriteLine("String Interopolation");
            string name = "Velammal Engineering College";
            Console.WriteLine($"I am studying in {name}");
            Console.WriteLine("\n");

            //Default Parameter
            Console.WriteLine("Default Parameter: Enter a value");
            int val = Convert.ToInt32(Console.ReadLine());
            MyDefaultParameter(val);
            Console.WriteLine("\n");

            Console.WriteLine("By Default");
            MyDefaultParameter();
            Console.WriteLine("\n");














        }
    }
}
