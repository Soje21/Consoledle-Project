using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CONSOLEDLE_APP
{
    public class GameMode1EngEasy
    {

        //GAMEMODE 1 ENGLISH (EASY) METHOD
        public static void GameMode1EnglishEasy()
        {
            //play background music
            SoundPlayer playSfx = new SoundPlayer("Undertale - Hotel.wav");
            playSfx.PlayLooping();

            //Initialize the word inventory
            string[] wordInventory = { "AMBER", "ALERT", "ACNES", "AVERT", "AVIAN", "AVOID", "AMAZE", "AVAST", "AGILE",
"BLAZE", "BLISS", "BRAID", "BRISK", "BERRY", "BRAVE", "BARGE", "BEACH", "BEARS", "BEGAN",
"CRISP", "CRANE", "CLOAK", "CIDER", "CHAIN", "CABAL", "CABIN", "CACHE", "CADET", "CADRE",
"DWELL", "DELUX", "DRAKE", "DIVER", "DWELL", "DWINE", "DOWER", "DRINK", "DROWN", "DRIFT",
"ELBOW", "EMAIL", "ENJOY", "EMPTY", "EAGLE", "EVOKE", "ENDED", "ELITE", "ENEMY", "EAGER",
"FROWN", "FLUTE", "FLAME", "FLOCK", "FROST", "FAINT", "FABLE", "FLARE", "FLUSH",
"GRASP", "GRACE", "GREET", "GRAND", "GAMMA", "GLIDE", "GLARE", "GLAZE",
"HORSE", "HASTE", "HEART", "HEXED", "HEART", "HORSE", "HEXED", "HINGE", "HEART",
"INERT", "IVORY", "ISSUE", "ICYTH", "INKED", "ISSUE", "ICING", "ICONS", "INDEX", "IMAGE",
"JOLLY", "JUMBO", "JAPAN", "JOKER", "JOINT", "JEANS", "JUDGE", "JOWAR", "JOCKY", "JUICY",
"KNEAD", "KITES", "KAYAK", "KNIFE", "KNOCK", "KILOS", "KNIFE", "KILLS", "KOALA",
"LADLE", "LABOR", "LURCH", "LAPSE", "LATCH", "LEMON", "LABLE", "LAPSE", "LATCH", "LIONS",
"MAPLE", "MOOSE", "MIGHT", "MACHO", "MAGIC", "MAPLE", "MIGHT", "MADLY", "MADAM",
"NAKED", "NANNY", "NASTY", "NASAL", "NIFTY", "NAIVE", "NIXON", "NACHO", "NERVE",
"OLIVE", "OBESE", "OASIS", "ONION", "OCEAN", "OMEGA", "OUGHT", "OUTDO", "OXIDE", "OWNER",
"PLAID", "PABLO", "PARTY", "PATCH", "PIXEL", "PEARL", "PEACE", "PEACH", "PITCH", "PHOTO",
"QUART", "QUEEN", "QUERY", "QUACK", "QUASI", "QUAIL", "QUICK", "QUIRK",
"RELAY", "RADAR", "RIDER", "RUGBY", "RABID", "RAILS", "RACER", "RIDGE", "ROUTE", "ROYAL",
"SWEEP", "SWIFT", "SABER", "SHOES", "SALAD", "SALES", "SACKS", "SADLY", "SAFER",
"TWIST", "TRACE", "TRUTH", "TREAT", "THANK", "TROOP", "TOUGH", "THUMB", "TRAIT", "THICK",
"USUAL", "UNCLE", "UPTON", "ULCER", "UNFIT", "UNIFY", "UNDER", "ULTRA", "UNIFY", "UNCUT",
"VOWEL", "VAGUE", "VAPOR", "VASES", "VALID", "VIDEO", "VOICE", "VIVID", "VOMIT",
"WACKY", "WOVEN", "WORTH", "WHISK", "WAFER", "WORTH", "WEIGH", "WHOOP", "WIPED", "WOMEN",
"XENON", "XEROX", "YACHT", "YAHOO", "ZEBRA", "ZEALS", "ZONED", "ZOOTY", "ZESTY" };

            /* Clearing the whole page to start the gameplay on a less-text page */
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            //GAME TITLE
            Text.GameTitle();

            /* Choosing a random guess word */
            Random random = new Random();
            int randomGuessWord = random.Next(wordInventory.Length);
            string guessWord = wordInventory[randomGuessWord];

            //initialize each char from the guessword
            char firstLetter = guessWord[0];
            char secondLetter = guessWord[1];
            char thirdLetter = guessWord[2];
            char fourthLetter = guessWord[3];
            char fifthLetter = guessWord[4];

            Function.CenterText("Guess the word! Five(5) letters only!");
            //if the Guess Word has a duplicate letter, it will inform the user
            if (firstLetter == secondLetter || firstLetter == thirdLetter || firstLetter == fourthLetter || firstLetter == fifthLetter || secondLetter == thirdLetter || secondLetter == fourthLetter || secondLetter == fifthLetter || thirdLetter == fourthLetter || thirdLetter == fifthLetter || fourthLetter == fifthLetter)
            {
                Function.CenterText("Caution: The Guess Word has duplicate letter/s! Goodluck! ");
            }

            //NO. OF ATTEMPTS DISPLAY
            int attemptText = 1;
            //Loop for user input
            for (int attempts = 1; attempts <= 6; attempts++)
            {
                int arraySize = 5;
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

                //Convert the characters from the picked random word into an array of the attempt 1
                Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.CursorTop);
                string attempt1UserInput = Console.ReadLine().ToUpper();

                //Clears the input
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Function.ClearCurrentConsoleLine();

                //If the user input is 4 or less character
                if (attempt1UserInput.Length < 5) {
                    Function.CenterTextLine("Insufficient letters, Input must only consist of Five(5) Letters! Please press any key to continue.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                //If the user input is 6 or more characters
                else if (attempt1UserInput.Length > 5)
                {
                    Function.CenterTextLine("Letter limit exceeded, Input must only consist of Five(5) Letters! Please press any key to continue.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }
                else
                {
                    
                    //initialize each char from the user input
                    char firstLtrAttempt = attempt1UserInput[0];
                    char secondLtrAttempt = attempt1UserInput[1];
                    char thirdLtrAttempt = attempt1UserInput[2];
                    char fourthLtrAttempt = attempt1UserInput[3];
                    char fifthLtrAttempt = attempt1UserInput[4];

                    // Character checker for each user input
                    //First letter
                    if (firstLtrAttempt == firstLetter)
                    {
                        SoundPlayer characterCheckEasySfx = new SoundPlayer("sfx5.wav");
                        characterCheckEasySfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (firstLtrAttempt == secondLetter || firstLtrAttempt == thirdLetter || firstLtrAttempt == fourthLetter || firstLtrAttempt == fifthLetter)
                    {
                        SoundPlayer characterCheckSfx1 = new SoundPlayer("sfx5.wav");
                        characterCheckSfx1.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If any character input is wrong
                    else
                    {
                        SoundPlayer characterCheckSfx1 = new SoundPlayer("sfx5.wav");
                        characterCheckSfx1.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.CursorTop);
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
                        Thread.Sleep(300);
                    }
                    //If the character input is in wrong position
                    else if (fifthLtrAttempt == firstLetter || fifthLtrAttempt == secondLetter || fifthLtrAttempt == thirdLetter || fifthLtrAttempt == fourthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(fifthLtrAttempt);
                        Thread.Sleep(300);
                    }

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(fifthLtrAttempt);
                        Thread.Sleep(300);
                    }
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
