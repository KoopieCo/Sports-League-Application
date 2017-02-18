using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_League_Application
{
    class Global
    {
        public string debugString;
        public List<League> createdLeagues;
        public League selectedLeague;

        private static Global instance = new Global();
        private Global() {
            createdLeagues = new List<League>();
            League newLeague = new League("Rainbow Road League", "Fall", "Spring", "Play-Off");
            createdLeagues.Add(newLeague);
            selectedLeague = new League();
            debugString = "Default";
        }
        public static Global Instance
        {
            get {
                return instance;
            }
        }
    }
}
