using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class Function
    {

        //CENTER TEXT METHOD
        public static void CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;
            int leftMargin = (screenWidth - stringWidth) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(text);
        }

        public static void CenterTextLine(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;
            int leftMargin = (screenWidth - stringWidth) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.Write(text);
        }
        //TO CLEAR THE INPUT METHOD 
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        //TO CLEAR THE INPUT 2 lines ABOVE
        public static void ClearCurrentConsoleLine2()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
