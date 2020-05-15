using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class PlayersWithCharacter
    {
        public int Id { get; set; }
        public int? CharacterTableId { get; set; }
        public int? RecordId { get; set; }

        public virtual CharacterTable CharacterTable { get; set; }
        public virtual Records Record { get; set; }
    }
}
