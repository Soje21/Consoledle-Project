using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class GameMode2EngHard
    {

        //GAMEMODE 2 (HARD) METHOD
        public static void GameMode2EnglishHard()
        {
            //play background music
            SoundPlayer playSfx = new SoundPlayer("Undertale - Hotel.wav");
            playSfx.PlayLooping();

            Again:
            /* Clearing the whole page to start the gameplay on a less-text page */
            Console.Clear();

            // GAME TITLE
            Text.GameTitle();

            //User input for the guess word
            Function.CenterText("Player 1, Please enter your guess word (must consist of  seven(7) leters only!)");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
            string guessWord = Console.ReadLine().ToUpper();

            //If the user input for the guessword is 6 or less characters
            if (guessWord.Length < 7)
            {
                Function.CenterTextLine("Insufficient letters, Input must only consist of Seven(7) Letters! Please press any key to continue.");
                Console.ReadKey();
                goto Again;
            }

            //If the user input for the guessword is 8 or more characters
            else if (guessWord.Length > 7)
            {
                Function.CenterTextLine("Letter limit exceeded, Input must only consist of Seven(7) Letters! Please press any key to continue.");
                Console.ReadKey();
                goto Again;
            }

            //Clearing the console after the user inputs the guessword
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            //initialize each char from the guessword
            char firstLetter = guessWord[0];
            char secondLetter = guessWord[1];
            char thirdLetter = guessWord[2];
            char fourthLetter = guessWord[3];
            char fifthLetter = guessWord[4];
            char sixthLetter = guessWord[5];
            char seventhLetter = guessWord[6];

            //GAME TITLE
            Text.GameTitle();

            Function.CenterText("Player 2's Turn, Guess the word! Seven(7) letters only!");
            //if the Guess Word has a duplicate letter, it will inform the user
            if (firstLetter == secondLetter || firstLetter == thirdLetter || firstLetter == fourthLetter || firstLetter == fifthLetter || firstLetter == sixthLetter || firstLetter == seventhLetter || secondLetter == thirdLetter || secondLetter == fourthLetter || secondLetter == fifthLetter || secondLetter == sixthLetter || secondLetter == seventhLetter || thirdLetter == fourthLetter || thirdLetter == fifthLetter || thirdLetter == sixthLetter || thirdLetter == seventhLetter || fourthLetter == fifthLetter || fourthLetter == sixthLetter || fourthLetter == seventhLetter || fifthLetter == sixthLetter || fifthLetter == seventhLetter || sixthLetter == seventhLetter)
            {
                Function.CenterText("Caution: The Guess Word has duplicate letter/s! Goodluck! ");
            }

            //ATTEMPT TEXT DISPLAY
            int attemptText = 1;

            //Loop for user input
            int arraySize = 5;
            for (int attempts = 1; attempts <= 6; attempts++)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    Console.ResetColor();
                }
                if (attemptText <= 6)
                {
                    Console.WriteLine();
                    Function.CenterText("Attempt " + attemptText);
                    attemptText++;
                }
                if (attempts <= 6)
                {
                    Console.Write("");
                }

                //Convert the characters from the picked random word into an array of the attemp 1
                Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                string attempt1UserInput = Console.ReadLine().ToUpper();

                //Clears the input
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Function.ClearCurrentConsoleLine();

                //If the user input is 6 or less character
                if (attempt1UserInput.Length < 7)
                {
                    Function.CenterTextLine("Insufficient letters, Input must only consist of Seven(7) Letters! Please press any key to continue.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                //If the user input is 8 or more characters
                else if (attempt1UserInput.Length > 7)
                {
                    Function.CenterTextLine("Letter limit exceeded, Input must only consist of Seven(7) Letters! Please press any key to continue.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                else
                {

                    //Initialize each char from the user input
                    char firstLtrAttempt = attempt1UserInput[0];
                    char secondLtrAttempt = attempt1UserInput[1];
                    char thirdLtrAttempt = attempt1UserInput[2];
                    char fourthLtrAttempt = attempt1UserInput[3];
                    char fifthLtrAttempt = attempt1UserInput[4];
                    char sixthLtrAttempt = attempt1UserInput[5];
                    char seventhLtrAttempt = attempt1UserInput[6];

                    // Character checker for each user input
                    //First letter
                    if (firstLtrAttempt == firstLetter)
                    {
                        SoundPlayer characterCheckHardSfx = new SoundPlayer("sfx7.wav");
                        characterCheckHardSfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (firstLtrAttempt == secondLetter || firstLtrAttempt == thirdLetter || firstLtrAttempt == fourthLetter || firstLtrAttempt == fifthLetter)
                    {
                        SoundPlayer characterCheckHardSfx = new SoundPlayer("sfx7.wav");
                        characterCheckHardSfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If any character input is wrong
                    else
                    {
                        SoundPlayer characterCheckHardSfx = new SoundPlayer("sfx7.wav");
                        characterCheckHardSfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //Second letter
                    if (secondLtrAttempt == secondLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(secondLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (secondLtrAttempt == firstLetter || secondLtrAttempt == thirdLetter || secondLtrAttempt == fourthLetter || secondLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(secondLtrAttempt);
                    }

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(secondLtrAttempt);
                    }
                    //Third letter
                    if (thirdLtrAttempt == thirdLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(thirdLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (thirdLtrAttempt == firstLetter || thirdLtrAttempt == secondLetter || thirdLtrAttempt == fourthLetter || thirdLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(thirdLtrAttempt);
                    }

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(thirdLtrAttempt);
                    }
                    //Fourth letter
                    if (fourthLtrAttempt == fourthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(fourthLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (fourthLtrAttempt == firstLetter || fourthLtrAttempt == secondLetter || fourthLtrAttempt == thirdLetter || fourthLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(fourthLtrAttempt);
                    }

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(fourthLtrAttempt);
                    }
                    //Fifth letter
                    if (fifthLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(fifthLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (fifthLtrAttempt == firstLetter || fifthLtrAttempt == secondLetter || fifthLtrAttempt == thirdLetter || fifthLtrAttempt == fourthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(fifthLtrAttempt);
                    }

                    //Sixth letter
                    if (sixthLtrAttempt == sixthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (sixthLtrAttempt == firstLetter || sixthLtrAttempt == secondLetter || sixthLtrAttempt == thirdLetter || sixthLtrAttempt == fourthLetter || sixthLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                    }
                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                    }

                    //Seventh letter
                    if (seventhLtrAttempt == seventhLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(seventhLtrAttempt);
                        Thread.Sleep(600);
                    }
                    //If the character input is in wrong position
                    else if (seventhLtrAttempt == firstLetter || seventhLtrAttempt == secondLetter || seventhLtrAttempt == thirdLetter || seventhLtrAttempt == fourthLetter || seventhLtrAttempt == fifthLetter || seventhLtrAttempt == sixthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(seventhLtrAttempt);
                        Thread.Sleep(600);
                    }
                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(seventhLtrAttempt);
                        Thread.Sleep(600);
                    }

                    //plays the background music after character checking
                    playSfx.PlayLooping();

                    //result checker
                    if (attempt1UserInput == guessWord)
                    {
                        Console.ResetColor();
                        Console.Write("\n");
                        Sound.CorrectGuessSfx();
                        Text.CorrectGuess();
                        Function.CenterText(@"Congratulations! You guessed the word ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Function.CenterText("'" + guessWord + "'!");
                        Console.ResetColor();
                        break;
                    }
                    if (attempt1UserInput != guessWord && attempts == 6)
                    {
                        Console.ResetColor();
                        Console.Write("\n");
                        Sound.WrongGuessSfx();
                        Text.WrongGuess();
                        Function.CenterText(@"Better luck next time! The word was ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Function.CenterText("'" + guessWord + "'!");
                        Console.ResetColor();
                    }
                }
            }
        }

    }
}
