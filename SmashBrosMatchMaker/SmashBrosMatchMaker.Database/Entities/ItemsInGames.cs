using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class ItemsInGames
    {
        public int Id { get; set; }
        public int? ItemsId { get; set; }
        public int? MatchTableId { get; set; }

        public virtual Items Items { get; set; }
        public virtual MatchTable MatchTable { get; set; }
    }
}
