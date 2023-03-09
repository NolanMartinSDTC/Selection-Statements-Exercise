namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Enter your favorite number: ");
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber < userInput)
            {
                Console.WriteLine("too high");
            }
            else if (favNumber > userInput)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed my favorite number.");
            }
        }
    }
}
