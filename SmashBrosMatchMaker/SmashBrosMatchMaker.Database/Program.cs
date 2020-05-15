using SmashBrosMatchMaker.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashBrosMatchMaker.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player
            {
                PlayerName = "thing",
                PlayerTypeId = 2,
                RecordId = 4
            };

            Console.WriteLine(DatabaseContext.Instance.Player.Count());

            DatabaseContext.Instance.Add(p);
            DatabaseContext.Instance.SaveChanges();

            Console.WriteLine(DatabaseContext.Instance.Player.Count());
        }
    }
}
