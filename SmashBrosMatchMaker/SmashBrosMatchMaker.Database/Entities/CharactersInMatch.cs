using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class CharactersInMatch
    {
        public int Id { get; set; }
        public int? MatchTableId { get; set; }
        public int? CharacterTableId { get; set; }

        public virtual CharacterTable CharacterTable { get; set; }
        public virtual MatchTable MatchTable { get; set; }
    }
}
