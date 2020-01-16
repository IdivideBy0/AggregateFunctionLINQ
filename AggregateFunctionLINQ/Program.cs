using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunctionLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] states = { "Illinois", "Wisconsin", "Indiana", "Iowa", "Kentucky" };



            //string result = states.Aggregate((a, b) => a + " * " + b);


            // a or accumulator is what stores the values that are aggregated from the aggregate function, 
            // b or builder is the next item to concatonate to the accumulator.

            string result = states.Aggregate((accumulator, builder) => accumulator + " * " + builder);



            Console.WriteLine(result);


        }
    }
}
