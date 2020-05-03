using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    class Match
    {
        int matchID;
        string MatchType;
        List<Character> characterList;
        string stageSelection;
        List<Items> itemList;
    }
}
