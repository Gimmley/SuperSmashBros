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
        
        public int MatchType;
        public int numPlayers;
        public bool isItems;
        public int itemPercent;
        public List<Player> playerList = new List<Player>();
        public List<Stage> stageList = new List<Stage>();
        public List<Items> itemList;
        public Dictionary<Player, CharacterTable> characterList = new Dictionary<Player, CharacterTable>();
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
