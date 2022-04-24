using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOMultiAccsCFG
{
    class MafileDeserialize
    {
        public class Session
        {
            public long SteamID { get; set; }
        }
        public class Root
        {
            public string revocation_code { get; set; }
            public string account_name { get; set; }
            public Session Session { get; set; }
        }
    }
}
