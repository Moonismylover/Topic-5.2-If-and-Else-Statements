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
            else if (grade <= 65)
                Console.WriteLine("That is a D!");
            else if (grade <= 75)
                Console.WriteLine("That is a C!");
            else if (grade <= 85)
                Console.WriteLine("That is a B!");
            else
                Console.WriteLine("That is an A!");

            /*
            What do you think 'else if' does?
            It checks for multiple conditions. If it finds the one that meets the conditions, and executes the code. 

            What does the else at the end do?
            It gives us a default code to execute in case all the previous conditions are not met.
            */

            // Task 1

            string userInput;

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is the color of the sky? \nPlease pick ONE of the following: \n\ta) RED \n\tb) ORANGE \n\tc) BLUE \n\td) GREEN");
            Console.Write("Enter here (name of color): ");
            Console.ForegroundColor = ConsoleColor.Red;
            userInput = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");

            if (userInput == "red")
                Console.WriteLine("Silly! The sky is not red!");

            else if (userInput == "orange")
                Console.WriteLine("Silly! The sky is not orange!");

            else if (userInput == "blue")
                Console.WriteLine("GREAT! The sky is indeed blue!");

            else 
                Console.WriteLine("Silly! The sky is not green! Go touch some grass!");

            Console.WriteLine(" ");

            // Task 2

            int temperature;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Input a temperature in Celsius and I will tell you the state of water in that specific temperature!");
            Console.Write("Enter here: ");
            Console.ForegroundColor = ConsoleColor.Red;
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            if (temperature <= 0)
                Console.WriteLine("The water is in solid state! Wanna eat some ice??");
            else if (temperature >= 0 && temperature <= 100)
                Console.WriteLine("The water is in liquid state! Wanna have a glass of water?");
            else
                Console.WriteLine("The water is in gaseous state! Wanna breathe!?");

            Console.WriteLine(" ");

            // Task 3

            int userAge;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your age: ");
            Console.ForegroundColor = ConsoleColor.Red;
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;

            if (userAge <= 0)
                Console.WriteLine("Invalid age input.");
            else if (userAge < 16)  
                Console.WriteLine("You can't drive.");
            else if (userAge < 17 && age >= 16)
                Console.WriteLine("You can drive but not vote.");
            else if (userAge > 18 && age < 24)
                Console.WriteLine("You can vote but not rent a car.");
  
            else
                Console.WriteLine("You can do pretty much everything! You can drive, vote, and rent a car!");
             





        }
    }
}
