namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "The hero awakens in a dank and dark room, their eyes slowly readjusting to their surroundings noticing they seem to be in a cell like room with metal bars and chains connected to their hands and feet anchoring them to the wall");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("The hero hears a rough sounding voice of an old man hidden in the shadows");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine(
                "The old man says: You have finally awoken I was beginning to worry the guards may have roughed you up to much... Say... you wouldn't mind sparing a few minutes of your time answering question's of a old man would you");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            //Added the Methods
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"{name}; So that is your name? how interesting");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite Color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} hahaha that is your Favorite color?");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} That is your favorite animal how bizarre");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine("Disgusting I would have personally chosen something better...");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Now for some Math questions your favorite... can you Add 2 plus 2? what is the answer?");
            int answer = int.Parse(Console.ReadLine());
            int correctAnswer = Add(2, 2);

            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The answer is {correctAnswer}.");
            }

            //Basic math operations methods
            static int Add(int numOne, int numTwo)
            {
                return numOne + numTwo;
            }

            static int Subtract(int numOne, int numTwo)
            {
                return numOne - numTwo;
            }

            static int Multiply(int numOne, int numTwo)
            {
                return numOne * numTwo;
            }

            static double Divide(int numOne, int numTwo)
            {
                if (numTwo == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                return (double)numOne / numTwo;
            }
        }
    }
}

    
        
    
