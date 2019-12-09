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
            int[] array1 = new int [100];
            int[] array2 = new int [100];
            //Using check to see how it behaves in the for loop
            int check = 0;

            //was going to time but stopwatch was not working;
            //var timer = new Stopwatch();

            //sequential way of filling an array
            for (int i = 0; i < 100; i++  )
            {


                array1[i] = i + check;
                Console.WriteLine("current number{0} equals {1}", i, array1[i] );
                check = i + 5;

            }
            // putting check bakc to zero
            check = 0;

            //parallel for option for filling an array.
            Console.WriteLine("parallel start");
            Parallel.For(0, 100, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, i =>
              {

                  array2[i] = i + check;
                  Console.WriteLine("current number{0} equals {1}", i, array2[i]);
                  check = i + 5;


              });


            Console.Read();
        }

    }
}
