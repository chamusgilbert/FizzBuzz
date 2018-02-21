using System;
namespace FizzBuzz
{
    static class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                //Method1(i);
                //Method2(i);
                Method3(i);
            }
        }
        public static void Method1(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
        public static void Method2(int i)
        {
            string str = "";
            if (i % 3 == 0)
            {
                str += "Fizz";
            }
            if (i % 5 == 0)
            {
                str += "Buzz";
            }
            if (str.Length == 0)
            {
                str = i.ToString();
            }
            Console.WriteLine(str);

        }
        public static void Method3(int i)
        {//This Method is created to run backwards, ie. "BuzzFizz".
            string str = "";
            if (i % 3 == 0)
            {
                str += "Buzz";
            }
            if (i % 5 == 0)
            {
                str += "Fizz";
            }
            if (str.Length == 0)
            {
                str = i.ToString();
            }
            Console.WriteLine(str);

        }
    }
}