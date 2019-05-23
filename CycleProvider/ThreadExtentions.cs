using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public static class ThreadExtentions
    {
        public static string Sleep(this int miliseconds, bool withLog = false)
        {
            string returnValue;

            var start = DateTime.Now;
            System.Threading.Thread.Sleep(miliseconds);
            returnValue = $"Slept: {start:hh:mm:ss:ms} to {DateTime.Now:hh:mm:ss:ms}";

            if (withLog) Console.WriteLine(returnValue);

            return returnValue;
        }

        public static string Sleep<Tstruct>(this Tstruct @struct, bool withLog = false, Action action = null) where Tstruct : struct
        {
            if (action != null) Task.Run(action);
      
            int ms = 0;
            if  (@struct is int || @struct is decimal)
            {
                ms = Convert.ToInt32(@struct);
            }

            return Sleep(ms, withLog);

        }
    }
}
