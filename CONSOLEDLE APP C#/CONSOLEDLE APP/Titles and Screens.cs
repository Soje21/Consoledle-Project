using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class Text
    {
        //GAME TITLE METHOD
        public static void GameTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            // The design for the title may not be similar when copy pasted into a document
            Function.CenterText(@"              /$$$$$$                                     /$$               /$$/$$                     ");
            Function.CenterText(@"             /$$__  $$                                   | $$              | $| $$                     ");
            Function.CenterText(@"            | $$  \__/ /$$$$$$ /$$$$$$$  /$$$$$$$ /$$$$$$| $$ /$$$$$$  /$$$$$$| $$ /$$$$$$             ");
            Function.CenterText(@"            | $$      /$$__  $| $$__  $$/$$_____//$$__  $| $$/$$__  $$/$$__  $| $$/$$__  $$            ");
            Function.CenterText(@"            | $$     | $$  \ $| $$  \ $|  $$$$$$| $$  \ $| $| $$$$$$$| $$  | $| $| $$$$$$$$            ");
            Function.CenterText(@"            | $$    $| $$  | $| $$  | $$\____  $| $$  | $| $| $$_____| $$  | $| $| $$_____/            ");
            Function.CenterText(@"            |  $$$$$$|  $$$$$$| $$  | $$/$$$$$$$|  $$$$$$| $|  $$$$$$|  $$$$$$| $|  $$$$$$$            ");
            Function.CenterText(@"             \______/ \______/|__/  |__|_______/ \______/|__/\_______/\_______|__/\_______/            ");
            Console.WriteLine(" \n");
            Console.ResetColor();
        }

        //CorrectGuess Screen Method
        public static void CorrectGuess()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            // The design for the title may not be similar when copy pasted into a document
            Function.CenterText(@"  / $$$$$$                                              /$$            /$$ ");
            Function.CenterText(@" / $$__  $$                                             |$$           | $$ ");
            Function.CenterText(@"| $$  \__/ /$$$$$$ /$$$$$$$  /$$$$$$  /$$$$$$ /$$$$$$ /$$$$$$  /$$$$$$| $$ ");
            Function.CenterText(@"| $$      /$$__  $| $$__  $$/$$__  $$/$$__  $|____  $|_  $$_/ /$$_____| $$ ");
            Function.CenterText(@"| $$     | $$  \ $| $$  \ $| $$  \ $| $$  \__//$$$$$$$ | $$  |  $$$$$$|__/ ");
            Function.CenterText(@"| $$    $| $$  | $| $$  | $| $$  | $| $$     /$$__  $$ | $$ /$\____  $$    ");
            Function.CenterText(@"|  $$$$$$|  $$$$$$| $$  | $|  $$$$$$| $$    |  $$$$$$$ |  $$$$/$$$$$$$//$$ ");
            Function.CenterText(@" \______/ \______/|__/  |__/\____  $|__/     \_______/  \___/|_______/|__/ ");
            Function.CenterText(@"                           /$$  \ $$                                       ");
            Function.CenterText(@"                          |  $$$$$$/                                       ");
            Function.CenterText(@"                           \______/                                        ");
            Console.WriteLine(" \n");
            Console.ResetColor();
        }

        //TamangHula Screen Method
        public static void TamangHula()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Function.CenterText(@" /$$$$$$$$                                                     /$$               /$$         /$$");
            Function.CenterText(@"|__  $$__/                                                    | $$              | $$        | $$");
            Function.CenterText(@"   | $$ /$$$$$$ /$$$$$$/$$$$  /$$$$$$ /$$$$$$$  /$$$$$$       | $$$$$$$ /$$   /$| $$ /$$$$$$| $$");
            Function.CenterText(@"   | $$|____  $| $$_  $$_  $$|____  $| $$__  $$/$$__  $$      | $$__  $| $$  | $| $$|____  $| $$");
            Function.CenterText(@"   | $$ /$$$$$$| $$ \ $$ \ $$ /$$$$$$| $$  \ $| $$  \ $$      | $$  \ $| $$  | $| $$ /$$$$$$|__/");
            Function.CenterText(@"   | $$/$$__  $| $$ | $$ | $$/$$__  $| $$  | $| $$  | $$      | $$  | $| $$  | $| $$/$$__  $$   ");
            Function.CenterText(@"   | $|  $$$$$$| $$ | $$ | $|  $$$$$$| $$  | $|  $$$$$$$      | $$  | $|  $$$$$$| $|  $$$$$$$/$$");
            Function.CenterText(@"   |__/\_______|__/ |__/ |__/\_______|__/  |__/\____  $$      |__/  |__/\______/|__/\_______|__/");
            Function.CenterText(@"                                               /$$  \ $$                                        ");
            Function.CenterText(@"                                              |  $$$$$$/                                        ");
            Function.CenterText(@"                                               \______/                                         ");
            Console.WriteLine(" \n");
            Console.ResetColor();
        }

        //WrongGuess Screen Method
        public static void WrongGuess()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            // The design for the title may not be similar when copy pasted into a document
            Function.CenterText(@" /$$$$$$$$                         /$$             /$$                        /$$      /$$");
            Function.CenterText(@"| __ $$__/                        | $$            | $$                       | $$     | $$");
            Function.CenterText(@"   | $$  /$$$$$$ /$$   /$$ /$$$$$$| $$$$$$$       | $$      /$$   /$$ /$$$$$$| $$   /$| $$");
            Function.CenterText(@"   | $$ /$$__  $| $$   |$$/$$__  $| $$__  $$      | $$     | $$  | $$/$$_____| $$  /$$| $$");
            Function.CenterText(@"   | $$| $$  \ $| $$   |$| $$  \ $| $$  \ $$      | $$     | $$  | $| $$     | $$$$$$/|__/");
            Function.CenterText(@"   | $$| $$  | $| $$   |$| $$  | $| $$  | $|      | $$     | $$  | $| $$     | $$_ $$     ");
            Function.CenterText(@"   | $$|  $$$$$$|  $$$$$$|  $$$$$$| $$  | $$      | $$$$$$$|  $$$$$$|  $$$$$$| $$ \  $$/$$");
            Function.CenterText(@"   |__/ \______/ \______/ \____  $|__/  |__/      |________/\______/ \_______|__/  \__|__/");
            Function.CenterText(@"                           /$$ \ $$                                                       ");
            Function.CenterText(@"                          |  $$$$$/                                                       ");
            Function.CenterText(@"                           \_____/                                                        ");
            Console.WriteLine(" \n");
            Console.ResetColor();
        }

        //Maling Hula Screen Method
        public static void MalingHula()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Function.CenterText(@" /$$$$$$$                       /$$       /$$   /$$/$$/$$  /$$   /$$");
            Function.CenterText(@"| $$__  $$                     |__/      | $$  | $| $|__/ | $$  | $$");
            Function.CenterText(@"| $$  \ $$ /$$$$$$ /$$  /$$  /$$/$$      | $$  | $| $$/$$/$$$$$$| $$");
            Function.CenterText(@"| $$$$$$$ |____  $| $$ | $$ | $| $$      | $$  | $| $| $|_  $$_/| $$");
            Function.CenterText(@"| $$__  $$ /$$$$$$| $$ | $$ | $| $$      | $$  | $| $| $$ | $$  |__/");
            Function.CenterText(@"| $$  \ $$/$$__  $| $$ | $$ | $| $$      | $$  | $| $| $$ | $$ /$$  ");
            Function.CenterText(@"| $$$$$$$|  $$$$$$|  $$$$$/$$$$| $$      |  $$$$$$| $| $$ |  $$$$/$$");
            Function.CenterText(@"|_______/ \_______/\_____/\___/|__/       \______/|__|__/  \___/|__/");
            Console.WriteLine(" \n");
            Console.ResetColor();
        }

        //Choosing Gamemode
        public static void GameMode()
        {
            /* Function.CenterText to center all texts instead of using spaces in WriteLine */
            Function.CenterText("WELCOME TO CONSOLEDLE! \n");
            Function.CenterText("Please press ctrl + mousewheelup to modify the size of the console! \n");
            Function.CenterText("------------------------ How do you want to play?? ------------------------\n");
            Function.CenterText("Single Player Random (Type 1)  ::: 2 PLayers Chosen Word (Type 2) \n");
            Function.CenterText("FOR THE GAME INSTRUCTIONS (Type 3)");
        }

        //Choosing Language Method
        public static void GameLanguage()
        {
            Function.CenterText("------------------------ In what language do you want to play?? ------------------------\n");
            Function.CenterText("English (Type 1)  ::: Filipino (Type 2) \n");

        }

        // Choosing Difficulty Method
        public static void GameDifficulty()
        {
            Function.CenterText("------------------------ Please choose the Difficulty ------------------------\n");
            Function.CenterText("Easy (Type 1)  ::: Mediocre (Type 2) ::: Hard (Type 3) \n");
        }

        //instructions Screen
        public static void Instructions()
        {
            Function.CenterText("INSTRUCTIONS: The Game 'CONSOLEDLE' is a guessing word game. Wherein the user input could be indicated as:");
            Console.ForegroundColor = ConsoleColor.Green;
            Function.CenterText("GREEN");
            Console.ResetColor();
            Function.CenterText("Indicates that the character input is in the Guess Word and in the right order");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Function.CenterText("YELLOW");
            Console.ResetColor();
            Function.CenterText("Indicates that the character input is in the Guess Word but in the wrong order");

            Console.ForegroundColor = ConsoleColor.Red;
            Function.CenterText("RED");
            Console.ResetColor();
            Function.CenterText("Indicates that the character input is NOT in the Guess Word");
            Function.CenterText("");
        }

    }
}
