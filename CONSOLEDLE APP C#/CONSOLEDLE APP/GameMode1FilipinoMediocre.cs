using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class GameMode1FilMediocre
    {

        //GAMEMODE 1 FILIPINO (MEDIOCRE) METHOD
        public static void GameMode1FilipinoMediocre()
        {
            //play background music
            SoundPlayer playSfx = new SoundPlayer("Undertale - Hotel.wav");
            playSfx.PlayLooping();

            //Initialize the word inventory
            string[] wordInventory = { "ABAKUS", "ABUBOT", "ABULOY", "AGAHAN", "AGIMAT", "AHENTE", "AKSYON", "AKTWAL", "ALAALA", "ALAGAD", "ALAMAT", "ALARMA", "ALERTO", "ALIPIN", "ALYADO", "ANGKAT", "ANGKOP",
        "BABALA", "BADYET", "BAGSAK", "BAGITO", "BAGKOS", "BAHAGI", "BALBAS", "BABALA", "BALITA", "BULKAN", "BALOTA", "BANGIS", "BANGIN", "BANGIN", "BANGUS", "BANSOT", "BARAKO", "BASBAS", "BIHIRA", "BINATA",
        "DAGDAG", "DALAGA", "DALIRI", "DANYOS", "DIBDIB", "DOKTOR", "DOLYAR", "DEKADA", "DANGAL", "EKSENA", "EKSTRA", "ENSAYO", "EPEKTO", "ESKIMO", "ESPADA", "ETNIKO", "GADYET", "GALANG", "GALING", "GASTOS",
        "GANYAN", "GARAHE", "GAROTE", "GASGAS", "GATONG", "GINANG", "GULONG", "GARTER", "HALATA", "HAPLOS", "HALANG", "HALIGI", "HALAYA", "HAMBOG", "HAMPAS", "HANDOG", "HANGAD", "HANGAL", "HARANA", "HARDIN",
        "HAYAAN", "HERBAL", "HIGAAN", "HINALA", "IBABAW", "IKATLO", "ISTILO", "INGGIT", "ITSURA", "ISKWAT", "KAAWAY", "KABAYO", "KABILA", "KABUTE", "KADETE", "KADENA", "KAILAN", "KAMBAL", "KAMOTE", "KARATE",
        "KARERA", "KAWALI", "GITARA", "KUSINA", "KWARTO", "KWENTO", "LIGTAS", "LABABO", "LINDOL", "LINGGO", "LANGAW", "LIMBAG", "LASING", "LABUYO", "LAGNAT", "LAGPAS", "LAKBAY", "LAMBOT", "LAMESA", "LANDAS",
        "LANGIS", "LANGIT", "LIBLIB", "LANGIB", "MILYON", "MEDYAS", "MARTIR", "MUNTIK", "MINSAN", "MARTES", "MANGGA", "MAKINA", "MANILA", "MASKOT", "MENUDO", "MORENA", "MORENO", "MUNGGO", "NINANG", "NGUNIT",
        "NINONG", "OBISPO", "OBLONG", "ORASAN", "PAALAM", "PABAYA", "PAKETE", "PALAKA", "PALAPA", "PALPAK", "PAKPAK", "PANALO", "PANATA", "PANGIT", "PANTAY", "PARAAN", "PASTOR", "PATING", "PATRON", "PATROL",
        "PAYONG", "PAYPAY", "PEKLAT", "PILOTO", "PIGING", "PANIKI", "PIRATA", "PANTAY", "PRUTAS", "PUNTOD", "PUTAHE", "PUWEDE", "PWESTO", "RAMDAM", "RAGASA", "RESIBO", "RAYUMA", "RETOKE", "REGALO", "SABADO",
        "SABLAY", "SAKLAY", "SAGLIT", "SAGWAN", "SAKLAW", "SAKSAK", "SALAPI", "SALITA", "SALTIK", "SAMPAL", "SAYANG", "SANDOK", "SANTOL", "SAPLOT", "SARADO", "SARILI", "SAKALI", "SAYOTE", "SESYON", "SEKTOR",
        "SAGING", "SINDAK", "SINGKO", "SKOLAR", "TUKTOK", "WALDAS", "UNGGOY" };

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

            Function.CenterText("Hulaan ang salita! Anim(6) na letra lamang!");
            //if the Guess Word has a duplicate letter, it will inform the user
            if (firstLetter == secondLetter || firstLetter == thirdLetter || firstLetter == fourthLetter || firstLetter == fifthLetter || firstLetter == sixthLetter || secondLetter == thirdLetter || secondLetter == fourthLetter || secondLetter == fifthLetter || secondLetter == sixthLetter || thirdLetter == fourthLetter || thirdLetter == fifthLetter || thirdLetter == sixthLetter || fourthLetter == fifthLetter || fourthLetter == sixthLetter || fifthLetter == sixthLetter)
            {
                Function.CenterText("Paalala: Mayroong letra ang nauulit sa salitang iyong huhulaan! ");
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
                    Function.CenterTextLine("Kulang ang mga letra! Anim(6) na Letra lamang! Mag-type ng kahit ano para umulit.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                //If the user input is 7 or more characters
                else if (attempt1UserInput.Length > 6)
                {
                    Function.CenterTextLine("Sobra ang mga letra! Anim(6) na Letra lamang! Mag-type ng kahit ano para umulit.");
                    Console.ReadKey();
                    Function.ClearCurrentConsoleLine2();
                    Function.ClearCurrentConsoleLine();
                    attempts--;
                    attemptText--;
                }

                else
                {
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

                    //plays the background music after character checking
                    playSfx.PlayLooping();

                    //result checker 
                    if (attempt1UserInput == guessWord)
                    {
                        Console.ResetColor();
                        Console.Write("\n");
                        Sound.CorrectGuessSfx();
                        Text.TamangHula();
                        Function.CenterText(@"Ang galing! Isa kang alamat! ");
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
                        Text.MalingHula();
                        Function.CenterText(@"Bawi nalang sa susunod! Ang tamang sagot ay ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Function.CenterText("'" + guessWord + "'!");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
