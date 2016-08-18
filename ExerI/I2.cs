using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerI
{
    class I2
    {

        //This program asks the user to key in 2 numbers: a and b
        //and then generates 50 integers from a (inclusive) to b (inclusive)
        //It then count the no of occurrence of each integer and plot
        //a histogram 

        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int k;
            int upperBound;
            int lowerBound;
            int randomArraySize;

            Console.WriteLine("Please enter the lowest number:  ");
            lowerBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the highest number:  ");
            upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the no of random integers to generate"
                + "from lowest to highest number");
            randomArraySize = Convert.ToInt32(Console.ReadLine());

            int[] randomArray = new int[randomArraySize];
            
            //Generate random integers and fill up the randomArray
            for (k=0; k<randomArraySize;k++)
            {
                //upperBound +1 because the Next method is exclusive for the upper bound               
                randomArray[k] = rnd.Next(lowerBound, upperBound+1);    
            }

            //integerCntArray will store the result of counting the no of occurrence
            //of each integer
            int[,] integerCntArray = new int[upperBound-lowerBound+1, 2];

            for ()



        }
    }
}
