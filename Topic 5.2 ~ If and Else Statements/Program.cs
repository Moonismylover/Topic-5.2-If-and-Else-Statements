using System.Diagnostics;

namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 5.2 ~ If and Else Statements";

            int grade, age, bet;

            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade >= 50)
                Console.WriteLine("You passed!");
            else 
                Console.WriteLine("Better luck next time!");

            /*
              What do you think 'else' does?
              The 'else' statement allows us to execute another code if the input does not meet the previous condition.
            */

            Console.WriteLine(" ");

            Console.Write("What is your age? \nEnter here: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (age >= 16)
                Console.WriteLine("The road are not safe!");
            else
                Console.WriteLine("I can drive without fear!");

            Console.WriteLine(" ");

            Console.Write("How much would you like to bet? \nEnter here: ");
            
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine(" ");
                Console.WriteLine("You bet " + bet.ToString("C"));
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("That is not a valid number.");
                Console.WriteLine("Your bet will be set to the minimum of $1.00.");
                bet = 1;
            }

            Console.WriteLine(" ");

            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(),out grade);

            if (grade < 50)
                Console.WriteLine("That is an F!");
            if (grade <= 65)
                Console.WriteLine("That is a D!");
            if (grade <= 75)
                Console.WriteLine("That is a C!");
            if (grade <= 85)
                Console.WriteLine("That is a B!");
            if (grade > 85)
                Console.WriteLine("That is an A!");










        }
    }
}
