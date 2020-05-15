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
using SmashBrosMatchMaker.forms;
using SmashBrosMatchMaker.MatchInfo;

namespace SmashBrosMatchMaker.forms
{
   public partial class Choose_Winner : Form
   {
      static IOControl controller = IOControl.Instance;
      public int numPlayers { get; set; }
      public List<Player> playerList = new List<Player>();
      public Match match;
        

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
                cmbWinner.Items.Add(player.PlayerName);
         }
      }
      public bool isEmpty()
        {
            if (cmbWinner.SelectedItem == null)
            {
                lblError.Text = "Please select Winner";
                return true;
            }
            return false;
        }

      private void button1_Click(object sender, EventArgs e)
      {
         if (isEmpty())
                return;
         string winnerName = cmbWinner.GetItemText(this.cmbWinner.SelectedItem);
         
         foreach (Player player in playerList)
         {
            if (winnerName == player.PlayerName)
            {
                winner = player;
                //increment wins via database
            }
            
                 //else set winstreak to 0
         }
            cmbWinner.Items.Clear();
         this.Hide();
         
         controller.openRecords(winner,match);
      }
   }
}
