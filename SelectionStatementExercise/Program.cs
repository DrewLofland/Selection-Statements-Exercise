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

            
            
            Console.WriteLine("What is you favorite school subject?");
            string myfavSubject = Console.ReadLine();

            switch(myfavSubject.ToLower())
            {
                case "language arts":
                case "english":
                    Console.WriteLine("english/language arts is my favorite too!");
                    break;
                case "mathematics":
                case "math":
                    Console.WriteLine("math is important!");
                    break;
                case "science":
                    Console.WriteLine("science is fun!");
                    break;
                case "social studies":
                case "history":
                    Console.WriteLine("history taught in school is not always accurate though!");
                    break;
                case "art":
                    Console.WriteLine("art is not for everybody");
                    break;
                default: Console.WriteLine("Hmm, I am not familiar with that subject.");
                    break;

            }
                

            
         
            {

            }
        }
    }
}
