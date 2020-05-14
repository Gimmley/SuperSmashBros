using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    class Player
    {
        List<Character> characterList = new List<Character>();
        public int winCount { set; get; }
        public int winStreak { set; get; }
        int playerID { set; get; }
        string playerName { set; get; }
        public Player(int playerID, string name)
        {
            this.playerID = playerID;
            playerName = name;
            winCount = 0;
            winStreak = 0;
        }

        public void addCharacter(Character newCharacter)
        {
            characterList.Add(newCharacter);
        }
        public void incrementTotalWins()
        {
            winCount++;
        }
    }
}
