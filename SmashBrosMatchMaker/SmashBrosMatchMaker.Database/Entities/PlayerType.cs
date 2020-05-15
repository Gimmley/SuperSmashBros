using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class PlayerType
    {
        public PlayerType()
        {
            Player = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string PlayerTypeName { get; set; }

        public virtual ICollection<Player> Player { get; set; }
    }
}
