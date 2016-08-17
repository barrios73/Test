using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerG
{
    
    class G1b
    {

        public static char[] charToChk = { 'a', 'e','d','f' };

        static void Main(string[] args)
        {
            string input;
            int n;
            int vowelCountSize = charToChk.Length;

            int[] vowelCount = new int[vowelCountSize+1];
            Console.WriteLine("Please input a pharse:");
            input = Console.ReadLine();
            Console.WriteLine();

            vowelCount = CountEachVowel(input);

            Console.WriteLine("Total no of vowels:  {0}", vowelCount[vowelCountSize]);

            for (n = 0; n < vowelCountSize; n++)
            {
                Console.WriteLine("{0}:  {1}", charToChk[n], vowelCount[n]);       
            }


        }

        public static int[] CountEachVowel(string input)
        {
            int m;            
            int charToChkSize = charToChk.Length;
            int[] vowelCount = new int[charToChkSize+1];
            int totalVowels = 0;

            for (m=0; m< charToChkSize; m++)
            {
                vowelCount[m] = input.Split(charToChk[m]).Length-1;
                totalVowels = totalVowels + vowelCount[m];
                //Console.WriteLine("{0}:  {1}", charToChk[m], vowelCount[m]);       
            }

            vowelCount[charToChkSize] = totalVowels;

            return vowelCount;

        }

        
    }
}
