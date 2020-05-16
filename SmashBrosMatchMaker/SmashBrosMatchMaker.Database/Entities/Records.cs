using System;
using System.Collections.Generic;

namespace SmashBrosMatchMaker.Database.Entities
{
    public partial class Records
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string RecordName { get; set; }
        public int CurrentRecord { get; set; }

        public virtual Player Player { get; set; }
    }
}
