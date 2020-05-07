using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    public class Character
    {
        int playerNumber { set; get; }
        string name { set; get; }
        string origin { set; get; }
        public Character(int playerNumber, string name)
        {
            this.playerNumber = playerNumber;
            this.name = name;
        }
    }
}
