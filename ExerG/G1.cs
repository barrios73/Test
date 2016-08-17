using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerG
{
    class G1
    {
        static void Main(string[] args)
        {

            string input, charToCompare;
            int k;
            int noOfA = 0;
            int noOfE = 0;
            int noOfI = 0;
            int noOfO = 0;
            int noOfU = 0;
            int totalVowels;

            Console.Write("Please input a phrase:   \t");
            input = (Console.ReadLine()).ToUpper();
            Console.WriteLine();

            for(k=0;k<input.Length;k++)
            {
                charToCompare = input.Substring(k, 1);

                switch (charToCompare)
                {
                    case "A":
                        noOfA = noOfA+1;
                        break;
                    case "E":
                        noOfE = noOfE + 1;
                        break;
                    case "I":
                        noOfI = noOfI + 1;
                        break;
                    case "O":
                        noOfO = noOfO + 1;
                        break;
                    case "U":
                        noOfU = noOfU + 1;
                        break;
                }
            }

            totalVowels = noOfA + noOfE + noOfI + noOfO + noOfU;

            Console.WriteLine("Total vowels: {0}", totalVowels);
            Console.WriteLine("A: \t {0}", noOfA);
            Console.WriteLine("E: \t {0}", noOfE);
            Console.WriteLine("I: \t {0}", noOfI);
            Console.WriteLine("O: \t {0}", noOfO);
            Console.WriteLine("U: \t {0}", noOfU);

        }
    }
}
