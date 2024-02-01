﻿/* 
 * Author: Saul B.
 * Course: COMP-003A-L01
 * Purpose:COMP003A.Assignment3
 */
namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numeric grade (0-100) :");
            string inputGrade = Console.ReadLine();
            if (double.TryParse(inputGrade, out double numericGrade) && numericGrade >= 0 && numericGrade <= 100) ;
            if (numericGrade >= 90)
                Console.WriteLine("Letter Grade: A");
            else if (numericGrade >= 80)
                Console.WriteLine("Letter Grade: B");
            else if (numericGrade >= 70)
                Console.WriteLine("Letter Grade: C");
            else if (numericGrade >= 60)
                Console.WriteLine("Letter Grade: D");
            else if (numericGrade >= 0)
                Console.WriteLine("Letter Grade: F");

            // Section 2
            Console.Write("Enter numeric day (1-7): ");
            string inputDay = Console.ReadLine();
            if (int.TryParse(inputDay, out int numericDay))
            {
                switch (numericDay)
                {
                    case 1:
                        Console.WriteLine("String Day: Monday");
                        break;
                    case 2:
                        Console.WriteLine("String Day: Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("String Day: Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("String Day: Thursday");
                        break;
                    case 5:
                        Console.WriteLine("String Day: Friday");
                        break;
                    case 6:
                        Console.WriteLine("String Day: Saturday");
                        break;
                    case 7:
                        Console.WriteLine("String Day: Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day!");
                        break;
                }
            }
           

           
        }
    }
}

        
            

