using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynkroniseringOpg1
{
    class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountUp);
            thread1.Start();
            Thread thread2 = new Thread(CountDown);
            thread2.Start();
            Console.Read();
        }

        static void CountUp()
        {
            while (true)
            {
                counter =+ counter + 2;
                Console.WriteLine(counter);
                Thread.Sleep(500);
            }
        }

        static void CountDown()
        {
            while (true)
            {
                counter =+ counter - 1;
                Console.WriteLine(counter);
                Thread.Sleep(500);
            }
        }
    }
}
