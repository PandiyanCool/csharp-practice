using System;
using System.Collections.Generic;

namespace dot_net_3._0_preview_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var experience = 3;

            // C# 7 pattern matching
            switch (experience)
            {
                case var exp when (experience > 0 & experience < 4):
                    Console.Write("Junior stage with {0} years of experience level", exp);
                    break;

                case var exp when (experience > 10):
                    Console.Write("Super senior stage with {0} years of experience level", exp);
                    break;

                case var exp when (new List<int>() { 4, 5, 6, 7 }).Contains(experience):
                    Console.Write("Mid level stage with {0} years of experience level", exp);
                    break;

                default:
                    Console.Write("code hits the default case");
                    break;
            }

            // C# 8 switch expressions

        }
    }
}
