using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLEDLE_APP
{
    public class Sound
    {
        public static void CorrectGuessSfx()
        {
            SoundPlayer correctGuess = new SoundPlayer("CorrectGuessSfx.wav");
            correctGuess.Play();
        }

        public static void WrongGuessSfx()
        {
            SoundPlayer wrongGuess = new SoundPlayer("WrongGuessSfx.wav");
            wrongGuess.Play();
        }
    }
}
