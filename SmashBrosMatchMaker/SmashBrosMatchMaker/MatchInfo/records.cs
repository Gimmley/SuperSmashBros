using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    class records
    {
        Player topPlayer;
        Player hotStreakPlayer;
        public bool checkTopPlayer(Player contendor)
        {
            return (contendor.winCount > topPlayer.winCount);
        }
        public Player setTopPlayer(Player contendor)
        {
            if(checkTopPlayer(contendor))
            {
                topPlayer = contendor;
            }
            return topPlayer;
        }
        public bool checkHotPlayer(Player contendor)
        {
            return (contendor.winStreak > hotStreakPlayer.winStreak);
        }
        public Player setHotPlayer(Player contendor)
        {
            if (checkTopPlayer(contendor))
            {
                hotStreakPlayer = contendor;
            }
            return hotStreakPlayer;
        }
    }
}
