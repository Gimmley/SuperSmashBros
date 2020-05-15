using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class StageType
    {
        public StageType()
        {
            Stage = new HashSet<Stage>();
        }

        public int Id { get; set; }
        public string StageTypeName { get; set; }

        public virtual ICollection<Stage> Stage { get; set; }
    }
}
