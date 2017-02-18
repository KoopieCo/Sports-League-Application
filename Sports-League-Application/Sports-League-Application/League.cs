using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_League_Application
{
    class League
    {
        public string name;
        public string start, end;
        public string type;

        public League()
        {
            name = "Default League";
            start = "A";
            end = "B";
            type = "C";
        }
        public League(string n, string s, string e, string t)
        {
            name = n;
            start = s;
            end = e;
            type = t;
        }
    }
}
