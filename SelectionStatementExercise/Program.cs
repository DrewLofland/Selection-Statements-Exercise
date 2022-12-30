namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 7;
            
            Console.WriteLine("Try to guess the number.Please enter a number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("That number is too low.");
                
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("That number is too high");
            }
            else 
            {
                Console.WriteLine("Congrats! You guessed it");
            }
            {

            }
        }
    }
}
