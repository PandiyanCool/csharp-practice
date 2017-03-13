using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int experience = 5;

        // Pattern matching in switch cases
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
    }
}
