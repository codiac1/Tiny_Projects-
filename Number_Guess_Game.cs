using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
class Game
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1 , 15);
        int numberOfGuess = 3;
        bool gameOver = false;
        int guess;
        Console.WriteLine("I am thinking about a number. Can you guess it?");

        while(gameOver == false) {
            guess = System.Convert.ToInt32(Console.ReadLine());
            numberOfGuess--;

            if(guess == randomNumber && numberOfGuess >= 0) {
                Console.WriteLine("Awesome! , You Win!");
                gameOver = true;
            } else if(guess != randomNumber && numberOfGuess == 0) {
                gameOver = true;
                Console.WriteLine("U Dumbo , You lose!");
            } else if(guess > randomNumber && numberOfGuess > 0) {
                Console.WriteLine("Ooops! , You got a bigger number");
            } else if(guess < randomNumber && numberOfGuess > 0) {
                Console.WriteLine("Ooops! , You got a smaller number");
            }
        }
        Console.ReadLine();
    }
}
}