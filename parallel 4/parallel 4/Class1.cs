using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallel_4
{
    public static class Tasks2
    {
        public static void Main()
        {
           // int results;

            //Task tasks1 = new Task;

            //Task factory made 
            Task<int> task1 = Task<int>.Factory.StartNew(() =>
            {
                int results = 5 + 5;
                //Thread.Sleep(1000);
                Console.WriteLine("task1 is done");
                return results;
               


            });
            //int task1result = task1.Result;
            Task<int> task2 = Task<int>.Factory.StartNew(() =>
            {
                int results = 5 * 5;
                //Thread.Sleep(1000);
                Console.WriteLine("task2 is done");
                return results;


            });
            //int task2result = task2.Result;

            Task<int> task3 = Task<int>.Factory.StartNew(() =>
            {
                int results = 5 / 5;
               // Thread.Sleep(1000);
                Console.WriteLine("task3 is done");
                return results;


            });
            int task1result = task1.Result;
            int task2result = task2.Result;
            int task3result = task3.Result;


            
            Console.WriteLine("The results are {0} {1} {2}", task1result,task2result,task3result) ;




          
            Console.Read();
        }



    }

}
