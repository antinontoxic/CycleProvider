using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider.ConsoleApp
{
    class Program
    {
        static CycleProvider<ConsoleColor> @lock = new CycleProvider<ConsoleColor>();

        static void Main(string[] args)
        {
            var t1 = new Task(TaskMethod1);
            var t2 = new Task(TaskMethod2);
            var t3 = new Task(TaskMethod3);
            var tClean = new Task(TaskMethodClear);

            @lock.Add(ConsoleColor.Blue);
            @lock.Add(ConsoleColor.Yellow);
            @lock.Add(ConsoleColor.White);
            @lock.Add(ConsoleColor.Green);

            t1.Start();
            t2.Start();
            t3.Start();
            tClean.Start();

            Task.WaitAll(t1, t2, t3);
        }

        private static void TaskMethod1()
        {

            string log;
            int i = 0;

            while (++i < 20)
            {
                log = 1000.Sleep();

                lock (@lock)
                    {
                        Console.ForegroundColor = @lock.Next();
                        Console.WriteLine($"t1[{i}] => {log}");
                    }
            }
        }

        private static void TaskMethod2()
        {
            string log;
            int i = 0;

            while (++i < 20)
            {
                log = 1000.Sleep();

                lock (@lock)
                    {
                        Console.ForegroundColor = @lock.Next();
                        Console.WriteLine($"t2[{i}] => {log}");
                    }
            }
        }

        private static void TaskMethod3()
        {
            string log;
            int i = 0;

            while (++i < 20)
            {
                log = 1000.Sleep();

                lock (@lock)
                    {
                        Console.ForegroundColor = @lock.Next();
                        Console.WriteLine($"t3[{i}] => {log}");
                    }
            }
        }

        private static void TaskMethodClear()
        {
            bool canClear = false;

            @lock.OnLastItem += (o, a) => canClear = true;

            while (true)
            {
                lock (@lock)
                {
                    if (canClear)
                    {
                        Console.Clear();
                        canClear = false;
                    }
                }
                
            }
        }

    }
}
