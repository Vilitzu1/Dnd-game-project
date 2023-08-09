using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    internal class Die
    {
        private static Random rnd = new Random();

        public static int Roll1d6()
        {
            return rnd.Next(1, 7);
        }

        public static int[] Roll2d6()
        {
            return new int[] { rnd.Next(1, 7), rnd.Next(1, 7) };
        }

        public static int Roll1d20()
        {
            return rnd.Next(1, 21);
        }
    }
}
