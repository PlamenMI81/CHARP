﻿using System;

namespace Problem4_Month_Printer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string monthStr;
            switch (month)
            {
                case 1:
                    monthStr = "January";
                    break;
                case 2:
                    monthStr = "February";
                    break;
                case 3:
                    monthStr = "March";
                    break;
                case 4:
                    monthStr = "April";
                    break;
                case 5:
                    monthStr = "May";
                    break;
                case 6:
                    monthStr = "June";
                    break;
                case 7:
                    monthStr = "July";
                    break;
                case 8:
                    monthStr = "August";
                    break;
                case 9:
                    monthStr = "September";
                    break;
                case 10:
                    monthStr = "Octomber";
                    break;
                case 11:
                    monthStr = "November";
                    break;
                case 12:
                    monthStr = "December";
                    break;
                default:
                    monthStr = "Error!";
                    break;
            }
            Console.WriteLine(monthStr);
        }
    }
}