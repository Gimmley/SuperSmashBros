using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmashBrosMatchMaker.Database.Entities;
using SmashBrosMatchMaker.MatchInfo;

namespace SmashBrosMatchMaker.forms
{
   public partial class Records : Form
   {
      static IOControl controller = IOControl.Instance;
      public Player winner { get; set; }
      public Stage currentStage { get; set; }
      public Records()
      {
         InitializeComponent();
      }
        

      public void fillFields(Match match)
      {
         lblPlayer.Text = winner.PlayerName;
         CharacterTable winChar = new CharacterTable();
         foreach(KeyValuePair<Player,CharacterTable> entry in match.characterList)
         {
                if(winner == entry.Key)
                {
                    lblCharacter.Text = entry.Value.CharacterName;
                    winChar = entry.Value;
                }
         }
         Moves move = Database.DatabaseContext.Instance.Moves.Where(foundMove => foundMove.CharacterTableId == winChar.Id).First();
         
         lblmove.Text = move.MoveName;
         lblStage.Text = match.stageList.Last().StageName;
         PlayerType type = Database.DatabaseContext.Instance.PlayerType.Where(foundType => foundType.Id == winner.PlayerTypeId).First();
         lblType.Text = type.PlayerTypeName + " Player:";
         List<Player> tempList = new List<Player>();

        tempList = Database.DatabaseContext.Instance.Player.ToList();

        int? p = Database.DatabaseContext.Instance.MatchTable.GroupBy(m => m.PlayerId).Select(m => new { Player = m.Key, TotalWins = m.Count() }).OrderByDescending(m => m.TotalWins).First().TotalWins;
        var p1 = Database.DatabaseContext.Instance.MatchTable.GroupBy(m => m.PlayerId).OrderByDescending(gp => gp.Count()).Take(1).Select(g => g.Key).ToList();
        
         lblMostWinsSet.Text = p.Value.ToString();

         Player player = Database.DatabaseContext.Instance.Player.Where(foundChar => foundChar.Id == p1[0]).First();
         lblMostWinName.Text = player.PlayerName;
      }

      private void btnNewMatch_Click(object sender, EventArgs e)
      {
         this.Hide();
         controller.openRules();
      }

    }
}
