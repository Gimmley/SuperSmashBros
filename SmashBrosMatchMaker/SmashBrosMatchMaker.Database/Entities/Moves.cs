using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Moves
    {
        public int Id { get; set; }
        public string MoveName { get; set; }
        public int? CharacterTableId { get; set; }

        public virtual CharacterTable CharacterTable { get; set; }
    }
}
