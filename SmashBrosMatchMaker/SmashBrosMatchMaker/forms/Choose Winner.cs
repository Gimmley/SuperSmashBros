using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashBrosMatchMaker.forms
{
   public partial class Choose_Winner : Form
   {
      static IOControl controller = IOControl.Instance;
      public int numPlayers { get; set; }

      private String[] twoPlayers = { "Player 1", "Player 2" };
      private String[] threePlayers = { "Player 1", "Player 2", "Player 3" };
      private String[] fourPlayers = { "Player 1", "Player 2", "Player 3", "Player 4" };
      private String[] fivePlayers = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5" };
      private String[] sixPlayers = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6" };
      private String[] sevenPlayers = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7" };
      private String[] eightPlayers = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5", "Player 6", "Player 7", "Player 8" };

      private string winner;

      public Choose_Winner()
      {
         InitializeComponent();
      }

      public void fillCombobox()
      {
         if (numPlayers == 2)
            cmbWinner.DataSource = twoPlayers;
         else if (numPlayers == 3)
            cmbWinner.DataSource = threePlayers;
         else if (numPlayers == 4)
            cmbWinner.DataSource = fourPlayers;
         else if (numPlayers == 5)
            cmbWinner.DataSource = fivePlayers;
         else if (numPlayers == 6)
            cmbWinner.DataSource = sixPlayers;
         else if (numPlayers == 7)
            cmbWinner.DataSource = sevenPlayers;
         else if (numPlayers == 8)
            cmbWinner.DataSource = eightPlayers;
         else
            cmbWinner.DataSource = "";

      }

      private void lblPlayer1_Click(object sender, EventArgs e)
      {

      }

      private void cmbPlayer1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void Choose_Winner_Load(object sender, EventArgs e)
      {
         
      }

      private void button1_Click(object sender, EventArgs e)
      {
         winner = cmbWinner.GetItemText(this.cmbWinner.SelectedItem);
         this.Hide();
         controller.openRecords(winner);
      }
   }
}
