using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    class Items
    {
        string itemName;
        float itemPercent { set; get; }
        public Items(string itemName)
        {
            this.itemName = itemName;
        }
    }
}
