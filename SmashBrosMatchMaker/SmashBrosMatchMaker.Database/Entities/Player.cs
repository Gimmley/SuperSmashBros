using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Player
    {
        public Player()
        {
            CharacterTable = new HashSet<CharacterTable>();
            Records = new HashSet<Records>();
        }

        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int? PlayerTypeId { get; set; }

        public virtual PlayerType PlayerType { get; set; }
        public virtual ICollection<CharacterTable> CharacterTable { get; set; }
        public virtual ICollection<Records> Records { get; set; }
    }
}
