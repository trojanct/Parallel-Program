using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parrallel_2
{
    
    public static class Parrallel_forloop
    {
       


        public static void Main()
        {
            int[] matrix1 = new int [100];
            int[] matrix2 = new int [100];
            int check = 0;
            var timer = new Stopwatch();

            for (int i = 0; i < 100; i++  )
            {


                matrix1[i] = i + check;
                Console.WriteLine("current number{0} equals {1}", i, matrix1[i] );
                check = i + 5;

            }

            check = 0;
            Console.WriteLine("parallel start");
            Parallel.For(0, 100, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, i =>
              {

                  matrix2[i] = i + check;
                  Console.WriteLine("current number{0} equals {1}", i, matrix2[i]);
                  check = i + 5;


              });


            Console.Read();
        }

    }
}
