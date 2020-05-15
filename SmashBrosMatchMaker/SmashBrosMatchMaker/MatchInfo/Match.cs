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
        List<Player> playerList;
        List<Stage> stageList;
        List<Items> itemList;
        public Match(string MatchType)
        {
            this.MatchType = MatchType;
        }
        public void addPlayer(Player newPlayer)
        {
            playerList.Add(newPlayer);
        }
        public void addStage(Stage stage)
        {
            stageList.Add(stage);
        }
    }
}
