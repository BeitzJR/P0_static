using System;

namespace CSharpConcepts
{

    class Program
    {

        static void Main(string[] args) 
        {
            bool test = false;
            int newint = 1;

            test = !(newint >= 5) || (newint <= 10);

            Console.WriteLine(test);

            newint = 6;

            test = !(newint >= 5) || (newint <= 10);

            Console.WriteLine(test);

            newint = 11;

            test = !(newint >= 5) || (newint <= 10);

            Console.WriteLine(test);


        }

    }

}