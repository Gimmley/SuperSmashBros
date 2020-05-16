using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class MatchTable
    {
        public MatchTable()
        {
            CharactersInMatch = new HashSet<CharactersInMatch>();
            ItemsInGames = new HashSet<ItemsInGames>();
        }

        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? GameTypeId { get; set; }
        public int? StageId { get; set; }
        public int? ItemsId { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual Items Items { get; set; }
        public virtual Player Player { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual ICollection<CharactersInMatch> CharactersInMatch { get; set; }
        public virtual ICollection<ItemsInGames> ItemsInGames { get; set; }
    }
}
