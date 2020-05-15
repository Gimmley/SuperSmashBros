using SmashBrosMatchMaker.Database;
using SmashBrosMatchMaker.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashBrosMatchMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Player p = new Player
            //{
            //    PlayerName = "testtesttest",
            //    PlayerTypeId = 2,
            //    RecordId = 4
            //};

            //Console.WriteLine(DatabaseContext.Instance.Player.Where(player => player.PlayerName == "test").FirstOrDefault());

            //DatabaseContext.Instance.Add(p);
            ////DatabaseContext.Instance.

            //Console.WriteLine(DatabaseContext.Instance.Player.Count());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Rules());
        }
    }
}
