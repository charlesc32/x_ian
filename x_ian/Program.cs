using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x_ian
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        public bool x_ian(string x, string word)
        {
            string test = "t".Substring(1);
            
            int idx;
            if (x.Length == 0) idx = 0;
            else
            {
                idx = word.IndexOf(x[0]);
            }

            if (idx < 0) return false;

            if (idx == x.Length) return true;
            
            return x_ian(x.Substring(1), word.Substring(idx));
        }

    }
}
