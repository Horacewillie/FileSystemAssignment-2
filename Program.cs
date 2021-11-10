using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace TimeLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "c://Assignment//LogFile.txt";
            File.Create(path);
            Stack<DateTime> time = new Stack<DateTime>();
            time.Push(DateTime.Now);
            Thread.Sleep(10000);

            time.Push(DateTime.Now);
            Console.WriteLine(time.Peek());
            Thread.Sleep(10000);

            time.Push(DateTime.Now);
            Console.WriteLine(time.Peek());
            Thread.Sleep(10000);

            

            foreach (var second in time)
            {
                File.AppendAllLines(path, new String[] { second.ToString() });
            }

            // Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            //Thread.Sleep(5000);
        }
    }
}