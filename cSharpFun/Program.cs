using System;

namespace cSharpFun
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintStuff ps = new PrintStuff("KH"); //instantiation//declaration
           

            string ?userName = "";
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            ps.PrintName(userName);
        }


    }
}
