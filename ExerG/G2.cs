using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExerG
{
    class G2
    {
        static void Main(string[] args)
        {
            //This program checks if an input string is a palindrome
            //A palindrome is a phrase that is spelled the same way when read forward 
            //or backwards

            string input;
            string onlyLetters="";
            int inputLength;
            int k;
            int m;
            int n;
            string w;


            //Get inputs
            Console.WriteLine("Please enter a phrase:");
            input = (Console.ReadLine()).ToUpper();
            inputLength = input.Length;

          
            //Create a dynamic array to hold the inpu phrase without space, punctuation marks etc.
            //ArrayList onlyLetters = new ArrayList();
            //string[] onlyLetters = new string[inputLength];

            //Extract only the alphabets from the input string
            for (k = 0; k <= inputLength-1; k++ )
            {
                if (Convert.ToChar(input.Substring(k,1)) >= 65 && (Convert.ToChar(input.Substring(k,1)) <= 90))     //65 is ascii code for A and 90 is ascii code for Z
                {
                    w = input.Substring(k, 1);
                    onlyLetters = onlyLetters + input.Substring(k, 1);
                }
            }

            //Get the size of the dynamic array
            //onlyLettersSize = onlyLetters.Length;
            //onlyLettersSize = onlyLetters.Count;

            //Start checking if input phrase is palindrome
            //m=0 means we are checking the characters from the left
            //n means checking the characters from the right
            //(n-m) has to be greater than 1 because for pharse with 
            //even characters, the difference in position of the 2 middle char
            //is 1 => we have search through the phrase.
            //For odd no of characters, the m=n for the middle character
            m = 0;
            n = onlyLetters.Length - 1;

            //If the input does not contain any letters, then it is not a palindrome
            //and we skip the check 

            if (string.IsNullOrEmpty(onlyLetters) == false)
            { 
                while (onlyLetters.Substring(m,1) == onlyLetters.Substring(n,1) && n - m > 1)
                {
                    m++;
                    n--;
                }

                if (onlyLetters.Substring(m, 1) != onlyLetters.Substring(n, 1))
                    Console.WriteLine("This is not a palindrome");
                else
                    Console.WriteLine("This is a palindrome");

            }

            else
            {
                Console.WriteLine("There are no letters in the phrase for checking");
            }
        }
    }
}
