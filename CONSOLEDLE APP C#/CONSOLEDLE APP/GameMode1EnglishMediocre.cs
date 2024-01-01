using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class GameMode1EngMediocre
    {
        //GAMEMODE 1 ENGLISH (MEDIOCRE) METHOD
        public static void GameMode1EnglishMediocre()
        {
            //play background music
            SoundPlayer playSfx = new SoundPlayer("Undertale - Hotel.wav");
            playSfx.PlayLooping();

            //Initialize the word inventory
            string[] wordInventory = { "ABOUND", "AMAZED", "ARCHED", "ASCEND", "ASSERT", "ASSIGN",
        "ATTACK", "AWAKEN", "BELLOW", "BOTTLE", "BUMPED", "BRAISE", "BLAZER", "BLIGHT", "BRAVED", "BOWLED",
        "COFFEE", "CIRCLE", "CRUNCH", "CARROT", "COOKIE", "CARVED", "CHEESE", "CHOOSE", "DINNER", "DOLLAR",
        "DEMAND", "DANGER", "DOCTOR", "DEEPER", "DESIRE", "DECIDE", "ESCAPE", "EXCUSE", "EXCEED", "ENJOYS",
        "EMPLOY", "ENDING", "EDITOR", "EXPERT", "FAMILY", "FOLLOW", "FORGET", "FRIEND", "FUTURE", "FAMOUS",
        "FROZEN", "FATHER", "GARDEN", "GLOBAL", "GUITAR", "GATHER", "GARTER", "GENTLE", "GRADLE", "GIGGLE",
        "HEALTH", "HANDLE", "HAPPEN", "HUNGRY", "HUMBLE", "HACKER", "HOBBIT", "HONEST", "INSIST", "IMPACT",
        "INFORM", "IGNITE", "INVEST", "ISLAND", "INFANT", "IGNORE", "JACKET", "JITTER", "JEWELS", "JUMPED",
        "JOYFUL", "JINGLE", "JOGGER", "JOKING", "KINDLY", "KETTLE", "KIDNAP", "KEYPAD", "KERNEL", "KIDNEY",
        "KILLER", "KNOCKS", "LAUNCH", "LEGACY", "LIVELY", "LEADER", "LIKELY", "LITTLE", "LOCATE", "LOVING",
        "MELLOW", "MIRROR", "MOTION", "MUFFIN", "MURMUR", "MUTUAL", "MANNER", "MENTOR", "NEARBY", "NARROW",
        "NATION", "NOTICE", "NORMAL", "NURSAL", "NUMBER", "NUANCE", "OUTLET", "OCULUS", "OFFICE", "ORANGE",
        "OBTAIN", "OUTFIT", "OXYGEN", "OUTING", "PRISON", "PLUNGE", "PENCIL", "PROFIT", "PURPLE", "PRAISE",
        "POLITE", "POETRY", "QUARRY", "QUARTZ", "QUENCH", "REASON", "ROBUST", "RECEDE", "REFUSE", "REVIEW",
        "REFUND", "REPAIR", "RETURN", "SUNSET", "SILVER", "SYSTEM", "SQUARE", "SISTER", "SIGNAL", "SUMMER",
        "SMOOTH", "TARGET", "TRAVEL", "THOUGH", "TOMATO", "TEMPER", "TODAYS", "TANGLE", "TENDER", "UNDOES",
        "URGENT", "UNPACK", "UNIQUE", "USEFUL", "URGING", "UNDEAD", "UNSEEN", "VISION", "VOYAGE", "VOLUME",
        "VALLEY", "VERIFY", "VANISH", "VACANT", "VELVET", "WISDOM", "WALLET", "WINDOW", "WONDER", "WORTHY",
        "WEEKLY", "WIZARD", "WRITER", "XENITH", "YELLOW", "YOGURT", "YEARLY", "YOGINI", "ZOMBIE", "ZIGZAG",
        "ZODIAC" };

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
            char sixthLetter = guessWord[5];

            Function.CenterText("Guess the word! Six(6) letters only!");
            //if the Guess Word has a duplicate letter, it will inform the user
            if (firstLetter == secondLetter || firstLetter == thirdLetter || firstLetter == fourthLetter || firstLetter == fifthLetter || firstLetter == sixthLetter || secondLetter == thirdLetter || secondLetter == fourthLetter || secondLetter == fifthLetter || secondLetter == sixthLetter || thirdLetter == fourthLetter || thirdLetter == fifthLetter || thirdLetter == sixthLetter || fourthLetter == fifthLetter || fourthLetter == sixthLetter || fifthLetter == sixthLetter)
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
                Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                string attempt1UserInput = Console.ReadLine().ToUpper();

                //Clears the input
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Function.ClearCurrentConsoleLine();

                //If the user input is 5 or less character
                if (attempt1UserInput.Length < 6)
                {
                    Function.CenterTextLine("Insufficient letters, Input must only consist of Six(6) Letters! Please press any key to continue.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                //If the user input is 7 or more characters
                else if (attempt1UserInput.Length > 6)
                {
                    Function.CenterTextLine("Letter limit exceeded, Input must only consist of Six(6) Letters! Please press any key to continue.");
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
                    char sixthLtrAttempt = attempt1UserInput[5];

                    // Character checker for each user input
                    //First letter
                    if (firstLtrAttempt == firstLetter)
                    {
                        SoundPlayer characterCheckMediocreSfx = new SoundPlayer("sfx6.wav");
                        characterCheckMediocreSfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If the character input is in wrong position
                    else if (firstLtrAttempt == secondLetter || firstLtrAttempt == thirdLetter || firstLtrAttempt == fourthLetter || firstLtrAttempt == fifthLetter)
                    {
                        SoundPlayer characterCheckMediocreSfx = new SoundPlayer("sfx6.wav");
                        characterCheckMediocreSfx.Play();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(firstLtrAttempt);
                    }
                    //If any character input is wrong
                    else
                    {
                        SoundPlayer characterCheckMediocreSfx = new SoundPlayer("sfx6.wav");
                        characterCheckMediocreSfx.Play();
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

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(fifthLtrAttempt);
                    }

                    //Sixth letter
                    if (sixthLtrAttempt == sixthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                        Thread.Sleep(450);
                    }
                    //If the character input is in wrong position
                    else if (sixthLtrAttempt == firstLetter || sixthLtrAttempt == secondLetter || sixthLtrAttempt == thirdLetter || sixthLtrAttempt == fourthLetter || sixthLtrAttempt == fifthLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                        Thread.Sleep(450);
                    }

                    //If any character input is wrong
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(150);
                        Console.Write(sixthLtrAttempt);
                        Thread.Sleep(450);
                    }

                    //plays the background music after checking each character
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
