using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerI
{
    class I1
    {

        static void Main(string[] args)
        {
            int i =0;
            int j = 0;
            int v;
            int w;
            int DenomArraySize;
            int amtRemainder;
            int TempDenom;
            double amtInput;

            double[] Denom = { 1.0, 0.5, 0.2,0.05  };   //array contains the denominations avaialble


            Console.WriteLine("Please enter the amount (e.g 3.5 for $3.5):   ");

            //Multiply by 100 to avoid floating point calculation later
            amtInput = Convert.ToDouble(Console.ReadLine()) * 100;  

            DenomArraySize = Denom.Length;
            //array contains the number of each denomination to make up the input amount
            int[] DenomQty = new int[DenomArraySize]; 

            amtRemainder = Convert.ToInt32(amtInput);

            do
            {
                TempDenom = Convert.ToInt32((Denom[i]*100)); //for checking
                if (amtRemainder / TempDenom >= 1)
                {
                    DenomQty[i] = amtRemainder / TempDenom;
                
                    v = TempDenom;  //for checking
                    w = DenomQty[i];  //for checking

                    amtRemainder = amtRemainder - DenomQty[i] * TempDenom;
                }
                i++;
                       
            } while (amtRemainder != 0);


            //Print the results
            for (j=0; j<DenomQty.Length;j++)
            {
                Console.WriteLine("Number of ${0,-4}:  {1}", Denom[j], DenomQty[j]);
            }


        }
    }
}
