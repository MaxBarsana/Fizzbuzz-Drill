using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 100; i++)
            {
                    
                string results = "";

                if (i % 3 == 0) results = "Fizz";
                if (i % 5 == 0) results = results + "Buzz";
            
                if (results.Length == 0) results = i.ToString();
                Console.WriteLine(results);

                if (i == 100)
                    Console.ReadKey();
             }

        }
    }
}
