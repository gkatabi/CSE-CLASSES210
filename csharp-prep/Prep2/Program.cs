using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* >= 90...A
              >= 80...B
              >= 70...C
              >= 60...D
              <  50...F*/
            Console.WriteLine("This is the grade finder");
            Console.WriteLine("What was your score?: ");
            string score = Console.ReadLine();
            int Score = Convert.ToInt32(Console.ReadLine());
            if (Score >= 90)
            {
                Console.WriteLine("You passed with: A");
            else if (Score >= 80)
                    Console.WriteLine("You have passed: B");
                else if (Score >= 70)
                    Console.WriteLine("You passed with:C");
                if (Score < 60)
                    Console.WriteLine("You passed with: D");
            }
            else
            {
                Console.WriteLine("You failed with: F");

            }
        }
    }
}