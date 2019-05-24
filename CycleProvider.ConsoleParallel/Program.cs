using CycleProvider.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider.ConsoleParallel
{
    class Program
    {
        static void Main ()
        {
            var sim = "9837487432";

            Parallel.ForEach(sim, c => Console.WriteLine($"Request for [{c}] | Response is: {GetFromOutsources(c)}"));

            //SingleThreadForeach(sim);
        }

        private static void SingleThreadForeach(string sim)
        {
            foreach (var item in sim)
            {
                Console.WriteLine($"Request for [{item}] | Response is: {GetFromOutsources(item)}");
            }
        }

        private static string GetFromOutsources (char item)
        {
            return 1000.Sleep();
        }
    }
}
