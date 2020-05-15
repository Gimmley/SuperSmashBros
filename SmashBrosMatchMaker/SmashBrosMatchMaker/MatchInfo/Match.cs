using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmashBrosMatchMaker.Database.Entities;

namespace SmashBrosMatchMaker.MatchInfo
{
    public class Match
    {
        
        public string MatchType;
        public int numPlayers;
        public List<Player> playerList;
        public List<Stage> stageList;
        public List<Items> itemList;
        public Dictionary<Player, CharacterTable> characterList;
        public Match()
        {
           
        }
        public void addPlayer(Player newPlayer)
        {
            playerList.Add(newPlayer);
        }
        public void addStage(Stage stage)
        {
            stageList.Add(stage);
        }
        public void addCharacter(Player owner ,CharacterTable newChar)
        {
            characterList.Add(owner, newChar);
        }
    }
}
