using System;
using System.Collections.Generic;

namespace Arrays_and_Lists___Exercise_3
{
    internal class Program
    {
        //3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        static void Main(string[] args)
        {
            int[] arrayOfUserInputNumbers = new int[5];

            List<int> listOfUserInputNumbers = new List<int>();

            while (listOfUserInputNumbers.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (listOfUserInputNumbers.Contains(userInput)) Console.WriteLine("You have entered a duplicate number, please try again");
                else listOfUserInputNumbers.Add(userInput);
            }
            listOfUserInputNumbers.Sort();
            
            foreach (int userInput in listOfUserInputNumbers)
            {
                Console.WriteLine(userInput);
            }




            //for (int requestOfNumber = 5; requestOfNumber > 0; requestOfNumber--)
            //{
            //    arrayOfUserInputNumbers[requestOfNumber] = Convert.ToInt32(Console.ReadLine());
            //}
            

            
          
        }
    }
}
