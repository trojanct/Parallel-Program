using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parrellel_1
{
    
    public static class Parrallel
    {
        public static void Threadworking()
        {
            int k =5;
            for (int i = 0; i < 100; i++)
            {
                {
                    Console.WriteLine("Thread number {0} equals {1}",i, k + i);


                }


            }

        }

        public static void Main()
        {
            int k = 5;
            Thread thread = new Thread(new ThreadStart(Threadworking));
            thread.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread running");

            }
            thread.Join();
            Console.WriteLine("stop");

        }
    }
}
