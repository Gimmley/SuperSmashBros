using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.MatchInfo
{
    public class Character
    {
        string name { set; get; }
        string origin { set; get; }
        public Character( string name)
        {
            this.name = name;
        }

    }
}
