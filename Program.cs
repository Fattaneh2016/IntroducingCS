
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 10;
            //int num2 = 20;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("hello world");
            //}
            //Program myintance = new Program();
            //myintance.testIfElse(1);
            //DoTest();
            //ForTest();
            //foreachTest();
            Factorial(0);

        }
        //if statement
        //public void testIfElse(int n)
        //{

        //    if (n > 10)
        //    {

        //        Console.WriteLine("num greater than 10");
        //    }
        //    else if (n < 4)
        //    {
        //        Console.WriteLine("num smaller than 10");
        //    }
        //    else
        //    {
        //        Console.WriteLine("good");
        //    }

        //}

        //while loop statement


        //switch statement
        //public void switchtest(int op1, int op2, char oper)
        //{
        //    int myResult;
        //    switch (oper)
        //    {
        //        case ('+'):
        //            myResult = op1 + op2;
        //            break;
        //        case ('_'):
        //            myResult = op1 - op2;
        //            break;

        //        default:
        //            Console.WriteLine("operator unknown");
        //            return;
        //    }
        //    Console.WriteLine("my result is {0}", myResult);
        //    return;
        //}


        ///while loop
        ///

        //public static void WhileTest()

        //{
        //    int i = 0;
        //    while (i<=2)
        //    {
        //        Console.WriteLine("while {0}", i);
        //        i++;
        //    }
        //}

        //do while 
        //private static void DoTest()
        // {
        //     int I = 5;
        //     do
        //     {
        //         Console.WriteLine(" do while loop {0}", I);
        //         ++I;

        //     } while (I <= 5);
        // }

        //for loop
        //private static void ForTest()
        //{
        //    for (int i = 0; i <= 5; i++)
        //    {
        //        Console.WriteLine("this is for loop {0}", i);
        //    }
        //}


        // foreach 

        //private static void foreachTest()
        //{

        //    string[] myarray = {"f", "j"};
        //    foreach (var item in myarray)
        //    {
        //        Console.WriteLine("foreach test {0}", item);
        //    }

        //}

        ///Recursive 
        ///
        public static int Factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
                
            }


        }
    }
}

