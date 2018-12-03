using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        //
        // Variables
        //
        
        // guessed letters (wrong and correct) will go in this list
        static List<string> guessedLetters = new List<string>();
        // guessed letters that are correct go in this list
        static List<string> correctLetters = new List<string>();
        // wrongly guessed letters will go in this list
        static List<string> guessedWrongLetters = new List<string>();
        // guessable words go in this list
        static List<string> words = new List<string>();
        // game loop
        static bool gameRunning = true;
        // Initializing hangman
        static HangmanEntity hangman = new HangmanEntity();

        static void Main(string[] args)
        { 
            welcome(); 
            start_game();
            endPrompt();
        }
        //
        // Welcoming Screen
        //
        static void welcome()
        {
            Console.WriteLine("Hello, welcome to Hangman.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
        }
        //
        // Starts the game
        //
        static void start_game()
        {
            words.Add("");
            Console.Clear();
            Console.WriteLine("");
            while (gameRunning)
            {
                // if hangman = true/gameover = true then break out of game loop and end.
                if (hangmanCheck()) {
                    gameOver();
                    break;
                }

            } 
        }
        //
        // Evaluates the picked letter
        //
        static void pickLetter()
        {

        }
        //
        // This method will be called if the picked letter isn't right
        // This method will add a part to the hangman 
        // Parts consist of Head, Torso, Left arm, Right Arm, Left Leg, Right Leg
        //
        static void addPart()
        {

        }
        //
        // Check hangman state
        //
        static bool hangmanCheck()
        {
            bool gameover = false;
            if (hangman.bpHead && hangman.bpLeft_Arm && hangman.bpLeft_Leg && hangman.bpRight_Arm && hangman.bpRight_Leg && hangman.bpTorso)
            {
                gameRunning = false;
                gameover = true; 
            }
            return gameover;
        }
        //
        // Displays the guessed letters to the user
        //
        static void getGuessedLetters()
        {

        }
        //
        // Displays the correct guessed letters to the user
        //
        static void getCorrectLetters()
        {

        }
        //
        // This method will return the parts of the hangman left (from the parts array)
        //
        static void partsLeft()
        {

        }
        //
        // This method will reset the game
        //
        static void resetGame()
        {
            //Clear out all of the guessed letters wrong, correct and guessed
            correctLetters.Clear();
            guessedLetters.Clear();
            guessedWrongLetters.Clear();


            //Resetting the getters/setters
            hangman.bpHead = false;
            hangman.bpLeft_Arm = false;
            hangman.bpLeft_Leg = false;
            hangman.bpRight_Arm = false;
            hangman.bpRight_Leg = false;
        }
        static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over!");
            Console.WriteLine();
            Console.WriteLine("You guessed wrong too many times!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void endPrompt()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing my app, Hangman.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
