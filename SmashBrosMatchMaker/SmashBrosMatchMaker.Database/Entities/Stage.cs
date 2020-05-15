using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Stage
    {
        public Stage()
        {
            MatchTable = new HashSet<MatchTable>();
        }

        public int Id { get; set; }
        public string StageName { get; set; }
        public int? StageTypeId { get; set; }
        public string GameOrigin { get; set; }

        public virtual StageType StageType { get; set; }
        public virtual ICollection<MatchTable> MatchTable { get; set; }
    }
}
