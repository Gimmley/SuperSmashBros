using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class CharacterTable
    {
        public CharacterTable()
        {
            CharactersInMatch = new HashSet<CharactersInMatch>();
            Moves = new HashSet<Moves>();
        }

        public int Id { get; set; }
        public string CharacterName { get; set; }
        public int? PlayerId { get; set; }
        public string GameOrigin { get; set; }

        public virtual Player Player { get; set; }
        public virtual ICollection<CharactersInMatch> CharactersInMatch { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
    }
}
