using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningDelegates
{
    //declare the delegate type
    //delegates are type safe; checks for signatures i.e. int arg 1 etc
    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string Func2(int a, int b)
        {
            return (a * b).ToString();
        }
        static void Main(string[] args)
        {
            MyDelegate f = Func1;
            Console.WriteLine("The number is: " + f(10, 20));

            //can dynamically switch at runtime
            f = Func2;
            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
        }
    }
}
