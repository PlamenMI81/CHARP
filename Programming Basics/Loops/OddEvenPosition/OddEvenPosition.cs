﻿using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0.0;
            double oddSum = 0.0;
            double evenMax = double.MinValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMin = double.MaxValue;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum = oddSum + number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }

                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
                else
                {
                    evenSum = evenSum + number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }
            Console.WriteLine("OddSum={0},", oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0},", oddMax);
            }
            Console.WriteLine("EvenSum={0},", evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0},", evenMax);
            }
        }
    }
}
