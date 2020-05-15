using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Records
    {
        public Records()
        {
            Player = new HashSet<Player>();
            PlayersWithCharacter = new HashSet<PlayersWithCharacter>();
        }

        public int Id { get; set; }
        public string RecordName { get; set; }
        public string CurrentRecord { get; set; }
        public bool IsBroken { get; set; }

        public virtual ICollection<Player> Player { get; set; }
        public virtual ICollection<PlayersWithCharacter> PlayersWithCharacter { get; set; }
    }
}
