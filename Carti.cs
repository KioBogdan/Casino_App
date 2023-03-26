using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atestat
{
    public class Carti
    {
        public int numar;
        public bool h;
        public bool s;
        public bool c;
        public bool d;

        public Carti()
        {
            numar = 0;
            h = false;
            c = false;
            s = false;
            d = false;
        }

        public Carti(int valoare)
        {
            numar = valoare;
            h = false;
            c = false;
            s = false;
            d = false;
        }
    }
}
