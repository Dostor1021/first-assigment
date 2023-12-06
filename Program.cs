using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tm = 1100;

            while (true)
            {
                Console.Write("Enter marks for a student (or enter -1 to exit): ");
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                int om= Convert.ToInt32(input);
                int per = (om * 100) / Tm;
                if (int.TryParse(input, out int on) && per >= 0 && per <= 100)
                {
                   

                    if (per >= 90)
                    {
                        Console.WriteLine("Congratulations! You have passed the exam and got an A grade. Excellent! your percentage is=" + per);
                    }
                    else if (per >= 80 && per < 90)
                    {
                        Console.WriteLine("Congratulations! You have passed the exam and got a B grade. Very good! your percentage is=" + per);
                    }
                    else if (per >= 70 && per < 80)
                    {
                        Console.WriteLine("Congratulations! You have passed the exam and got a C grade. Good! your percentage is=" + per);
                    }
                    else if (per >= 60 && per < 70)
                    {
                        Console.WriteLine("Congratulations! You have passed the exam and got a D grade. Satisfactory. your percentage is=" + per);
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, you have not passed the exam this time. Try again next year. Don't lose hope. your percentage is=" + per);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid marks.");
                }
            }
        }
    }
}