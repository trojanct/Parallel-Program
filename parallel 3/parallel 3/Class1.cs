using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallel_3
{
    public static class Tasks
    {
        public static void Main()
        {
            int outside = 0;
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() => {
                    Thread.Sleep(2000);
                    // if no sleep this gets different answers.
                    int check = i + 5;
                    outside = i + 10;
                    Console.WriteLine("check for task {0} = {1} and outside equals {2}", i, check, outside);
                });
                Console.WriteLine("task {0} running", i);

                //check does not exist out here.
                //Console.WriteLine("check for task {0} = {1}", i, check);
                
            

            }
            Task.WaitAll(tasks);


            Console.WriteLine("MISSION COMPLETE");
            Parallel.ForEach(tasks, t =>
             {
                 Console.WriteLine("Task #{0}: {1}", t.Id, t.Status) ;


             });

            Console.Read();
        }



    }
    
}
