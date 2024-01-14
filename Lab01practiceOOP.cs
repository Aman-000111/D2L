using System;
using System.Collections.Generic;
using System.IO;

namespace Lab01Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console WriteLine("Hello, World!");
            //Data types
            //int x = 10;
            //double d = 23.454649;
            //string s = "samuel";
            //char c = 'a';
            //bool status = true;
            ////Displaying into console //Console. WriteLine(status);
            //Console. WriteLine(s);
            ////Reading input from console
            //Console WriteLine("Kindly input anythin to tdisplay");
            //string userInput = Console. ReadLine);
            //Console WriteLine("This is what you inputted: " + user_input);


            //Conditional statements
            //if (x< 20)
            //}
            //   Console.WriteLine("The inputed number is less than 20");
            //}
            //else
            //{
            //   Console.WriteLine("The inputted number is too low");
            //}

            Console.Write("Task One");


            Console.WriteLine("Please enter a low number");
            string low = Console.ReadLine();
            int newLow;
            while (true)
            {

                if (int.TryParse(low, out newLow))
                {
                    Console.WriteLine(newLow);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            int newHigh;
            while (true)


                if (int.TryParse(low, out newHigh))
                {
                    Console.WriteLine(newHigh);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }


            int difference = newHigh - newLow;
            Console.WriteLine($"The difference between {newHigh} and {newLow} is {difference}");


            //Creating arrays
            int[] numArray = new int[10];
            int[] numArray1 = { 20, 30, 40, 50, 60 };
            numArray[3] = 30;

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i * 2;
                Console.WriteLine($"The value at index {i} is: {numArray[i]}");
            }

            //creating
            List<double> ListOfNumbers = new List<double>();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i * 2;
                Console.WriteLine($"The value at index {i} is: {numArray[i]}");
            }

            using (StreamWriter sw = new StreamWriter("numbers.txt"))
            {
                foreach (double number in ListOfNumbers)
                {
                    Console.WriteLine(number);
                    sw.WriteLine(number);
                }

                //console.Readkey();
            }
        }

        static int GetLowNumber(int highNum)
        {
            int newLow;
            while (true)
            {
                string low = Console.ReadLine();
                if (int.TryParse(low, out newLow) && newLow > highNum)
                {
                    //Console.WriteLine(newhigh);
                    return newLow;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        static int GetHighNumber(int lowNum)
        {
            int newHigh;
            while (true)
            {
                string high = Console.ReadLine();
                if (int.TryParse(high, out newHigh) && newHigh > lowNum)
                {
                    //Console.WriteLine(newhigh);
                    return newHigh;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

}


