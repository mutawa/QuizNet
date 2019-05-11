using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Extensions
{
    public static class Int
    {
        static Random r = new Random();
        public static int random(this int num, int min, int max)
        {
            return 0;
        }
        public static int random(int min, int max)
        {
            
            return r.Next(min, max);

        }
    }

}
