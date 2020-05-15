using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Player
    {
        public Player()
        {
            CharacterTable = new HashSet<CharacterTable>();
        }

        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int? PlayerTypeId { get; set; }
        public int? RecordId { get; set; }

        public virtual PlayerType PlayerType { get; set; }
        public virtual Records Record { get; set; }
        public virtual ICollection<CharacterTable> CharacterTable { get; set; }
    }
}
