using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Items
    {
        public Items()
        {
            ItemsInGames = new HashSet<ItemsInGames>();
            MatchTable = new HashSet<MatchTable>();
        }

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemPercent { get; set; }

        public virtual ICollection<ItemsInGames> ItemsInGames { get; set; }
        public virtual ICollection<MatchTable> MatchTable { get; set; }
    }
}
