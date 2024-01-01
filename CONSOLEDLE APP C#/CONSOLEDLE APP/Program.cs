// Startup
using System;
using System.Threading;
using System.Media;
using CONSOLEDLE_APP;

namespace CONSOLEDLEAPP
{
    class Program
    {
        static void Main(String[] args)
        {

            bool startUp = true;
            while (startUp)
            {
                //MENU
                SoundPlayer menuSfx = new SoundPlayer("Undertale - Menu.wav");
                menuSfx.PlayLooping();
                Text.GameTitle();
                Text.GameMode();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                string gameMode = Console.ReadLine();

                if (gameMode == "3")
                {
                    SoundPlayer instructionsSfx = new SoundPlayer("sans..wav");
                    instructionsSfx.PlayLooping();

                    Console.Clear();
                    Text.GameTitle();
                    Text.Instructions();
                    Function.CenterText("If you are done, Please press any key to go back to the main menu");
                    Console.ReadKey();
                    instructionsSfx.Stop();
                    continue;
                }

                Text.GameLanguage();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                string gameModeLanguage = Console.ReadLine();
                Text.GameDifficulty();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                string gameModeDifficulty = Console.ReadLine();
                menuSfx.Stop();

                //GAMEMODE 1
                if (gameMode == "1")
                {
                    if (gameModeLanguage == "1")
                    {
                        switch (gameModeDifficulty)
                        {
                            case "1":
                                GameMode1EngEasy.GameMode1EnglishEasy();
                                break;
                            case "2":
                                GameMode1EngMediocre.GameMode1EnglishMediocre();
                                break;
                            case "3":
                                GameMode1EngHard.GameMode1EnglishHard();
                                break;
                            default:
                                Function.CenterText("User input invalid, Please press any key to try again.");
                                Console.ReadKey();
                                continue;
                        }
                        //Ask the user if he/she wanted to try again
                        Function.CenterText("Would you like to play again? (Press 1)(press Enter if no)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "1")
                        {
                            startUp = true;
                        }
                        else
                        {
                            startUp = false;
                        }
                    }
                    else if (gameModeLanguage == "2")
                    {
                        switch (gameModeDifficulty)
                        {
                            case "1":
                                GameMode1FilEasy.GameMode1FilipinoEasy();
                                break;
                            case "2":
                                GameMode1FilMediocre.GameMode1FilipinoMediocre();
                                break;
                            case "3":
                                GameMode1FilHard.GameMode1FilipinoHard();
                                break;
                            default:
                                Function.CenterText("User input invalid, Please press any key to try again.");
                                Console.ReadKey();
                                continue;
                        }
                        //Ask the user if he/she wanted to try again
                        Function.CenterText("Gusto mo bang maglaro ulit? (I-type ang 1)(I-type ang Enter kung hindi)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "1")
                        {
                            startUp = true;
                        }
                        else
                        {
                            startUp = false;
                        }
                    }

                    else
                    {
                        Function.CenterText("User input invalid, Please press any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        startUp = true;
                    }
                    //END GAMEMODE 1
                }

                //GAMEMODE 2
                else if (gameMode == "2")
                {
                    if (gameModeLanguage == "1")
                    {
                        switch (gameModeDifficulty)
                        {
                            case "1":
                                GameMode2EngEasy.GameMode2EnglishEasy();
                                break;
                            case "2":
                                GameMode2EngMediocre.GameMode2EnglishMediocre();
                                break;
                            case "3":
                                GameMode2EngHard.GameMode2EnglishHard();
                                break;
                            default:
                                Function.CenterText("User input invalid, Please press any key to try again.");
                                Console.ReadKey();
                                continue;
                        }
                        //Ask the user if he/she wanted to try again
                        Function.CenterText("Would you like to play again? (Press 1)(press Enter if no)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "1")
                        {
                            startUp = true;
                        }
                        else
                        {
                            startUp = false;
                        }
                    }
                    else if (gameModeLanguage == "2")
                    {
                        switch (gameModeDifficulty)
                        {
                            case "1":
                                GameMode2FilEasy.GameMode2FilipinoEasy();
                                break;
                            case "2":
                                GameMode2FilMediocre.GameMode2FilipinoMediocre();
                                break;
                            case "3":
                                GameMode2FilHard.GameMode2FilipinoHard();
                                break;
                            default:
                                Function.CenterText("User input invalid, Please press any key to try again.");
                                Console.ReadKey();
                                continue;
                        }
                        //Ask the user if he/she wanted to try again
                        Function.CenterText("Gusto mo bang maglaro ulit? (I-type ang 1)(I-type ang Enter kung hindi)");
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "1")
                        {
                            startUp = true;
                        }
                        else
                        {
                            startUp = false;
                        }
                    }

                    else
                    {
                        Function.CenterText("User input invalid, Please press any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        startUp = true;
                    }
                    //END GAMEMODE 1
                }
                else
                    {
                        Function.CenterText("User input invalid, Please press any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        startUp = true;
                    }
                }
                Console.ReadKey();
            }
        }
    }