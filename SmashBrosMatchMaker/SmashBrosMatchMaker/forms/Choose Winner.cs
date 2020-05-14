using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmashBrosMatchMaker.MatchInfo;
using SmashBrosMatchMaker.forms;

namespace SmashBrosMatchMaker.forms
{
   public partial class Choose_Winner : Form
   {
      static IOControl controller = IOControl.Instance;
      public int numPlayers { get; set; }
      public List<Player> playerList = new List<Player>();
        

      private Player winner;

      public Choose_Winner()
      {
         InitializeComponent();
      }
      public void setPlayers(List<Player> ioList)
      {
            playerList = ioList;
      }

      public void fillCombobox()
      {
         
         foreach(Player player in playerList)
         {
                cmbWinner.Items.Add(player.playerName);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         string winnerName = cmbWinner.GetItemText(this.cmbWinner.SelectedItem);
         
         foreach (Player player in playerList)
         {
            if (winnerName == player.playerName)
            {
                winner = player;
                player.incrementTotalWins();
                player.winStreak++;
            }
            else
                player.winStreak =  0;
         }
         this.Hide();
         controller.openRecords(winner);
      }
   }
}
