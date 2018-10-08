// oshakaude oluwasola john
// adavanced c#
// 10/07/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnExampleOfDelegates
{
    public delegate string Hello(int a, int b);


    class Program
    {
        static string MethodDel(int num1, int num2)
        {
            if (num1 >= num2)
                return "greeter than";
            else
                return "less than";
        }

        static void Main(string[] args)
        {
            //Delegate Object
            Hello del_Obj = new Hello(MethodDel);
            Console.Write("Please enter the 1st Number ");
            int v1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the 2nd Number ");
            int v2 = Int32.Parse(Console.ReadLine());
            //Use the delegate object
            string res = del_Obj(v1, v2);
            Console.WriteLine("The 1st number is {0} the 2nd.", res);
            Console.ReadLine();
        }
    }
}
