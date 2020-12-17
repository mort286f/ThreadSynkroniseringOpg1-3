using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynkroniseringOpg2_3
{
    class Program
    {
        static int signCount = 0;
        static object lockObj = new object();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(WriteStars);
            thread1.Start();
            Thread thread2 = new Thread(WriteHashSigns);
            thread2.Start();
            Console.Read();
        }

        static void WriteStars()
        {
            while (true)
            {
                lock (lockObj)
                {
                    signCount = +signCount + 60;
                    Console.WriteLine("************************************************************ " + signCount);
                    Thread.Sleep(1000);
                }
            }
        }

        static void WriteHashSigns()
        {
            while (true)
            {
                lock (lockObj)
                {
                    signCount = +signCount + 60;
                    Console.WriteLine("############################################################ " + signCount);
                    Thread.Sleep(1000);
                }
            }
        }

    }
}
