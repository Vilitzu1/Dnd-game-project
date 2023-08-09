using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    static internal class MusicBox
    {
        public static void PlayFightSound()
        {
            Console.Beep(1300, 100);
            Console.Beep(1300, 100);

        }

        public static void PlayIntroSong()
        {
            Console.Beep();
            Console.Beep(1300, 100);
            Console.Beep(1300, 100);
            Console.Beep(315, 500);
            Console.Beep(354, 200);
            Console.Beep(578, 300);
            Console.Beep(297, 500);
            Console.Beep(693, 200);
            Console.Beep(785, 300);
            Console.Beep(815, 500);
            Console.Beep(1300, 400);
            Console.Beep(2000, 300);
            Console.Beep(315, 1000);
        }

        public static void PlayWinnermusic()
        {
            Console.Beep(1000, 400);
            Console.Beep(2000, 400);
            Console.Beep(2520, 400);
            Console.Beep(2520, 400);
            Console.Beep(2600, 800);
            Console.Beep(2520, 400);
            Console.Beep(3000, 400);
            Console.Beep(3020, 400);
            Console.Beep(3000, 400);
            Console.Beep(2520, 400);
        }

        public static void PlayDefeatmusic()
        {
            Console.Beep(375, 300);
            Console.Beep(375, 300);
            Console.Beep(375, 300);
            Console.Beep(315, 1200);

            Console.Beep(354, 300);
            Console.Beep(354, 300);
            Console.Beep(354, 300);
            Console.Beep(297, 1200);

        }
    }
}
