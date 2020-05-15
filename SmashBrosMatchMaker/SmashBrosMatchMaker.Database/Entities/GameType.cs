using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class GameType
    {
        public GameType()
        {
            MatchTable = new HashSet<MatchTable>();
        }

        public int Id { get; set; }
        public string GameTypeName { get; set; }

        public virtual ICollection<MatchTable> MatchTable { get; set; }
    }
}
