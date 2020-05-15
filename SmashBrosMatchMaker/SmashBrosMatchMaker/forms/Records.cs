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
         foreach(KeyValuePair<Player,CharacterTable> entry in match.characterList)
         {
                if(winner == entry.Key)
                {
                    lblCharacter.Text = entry.Value.CharacterName;
                }
         }
         lblStage.Text = match.stageList.Last().StageName;
         lblType.Text = winner.PlayerType + " Player:";
         /*if (Convert.ToInt32(lblMostWinsSet.Text) < winner.winCount)
         {
             lblMostWinsSet.Text = winner.winCount.ToString();
             lblMostWinName.Text = winner.PlayerName;
         }*/
         //lblHotStreakSet.Text = winner.winStreak.ToString();
         lblHotStreakName.Text = winner.PlayerName;
                
      }

      private void btnNewMatch_Click(object sender, EventArgs e)
      {
         this.Hide();
         controller.openRules();
      }

    }
}
