using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    public class Stage
    {
        public string name { set; get; }
        
        public string stageType { set; get; }

        public Stage (string name, string type)
        {
            this.name = name;
            stageType = type;
        }

    }
}
