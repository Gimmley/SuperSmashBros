using SmashBrosMatchMaker.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashBrosMatchMaker
{
    public partial class Rules : Form
    {
        static IOControl controller = IOControl.Instance;
        private bool firstGame = true;
        public Rules()
        {
            
            InitializeComponent();
        }
        //public int numPlayers { get; set; }

        private void bttConfirm_Click(object sender, EventArgs e)
        {
            controller.firstGame = firstGame;
            int numPlayers;
            if (firstGame)
                numPlayers = Convert.ToInt32(txtAIPlayers.Text) + Convert.ToInt32(txtHumanPlayers.Text);
            else
                numPlayers = controller.numPlayers;
            int itemPercent = 0;
            bool isItems;
            if (rdbYes.Checked)
            {
               isItems = true;
               itemPercent = Convert.ToInt32(txbItems.Text);
            }
            else
               isItems = false;
            if (numPlayers <= 8 && numPlayers >= 2)
            {
                this.Hide();
                controller.openSelectionScreen(numPlayers, isItems, itemPercent);
            }
            else
                lblError.Text = "Please select a valid number of players";
            
        }
      public void newGame()
      {
            firstGame = false;
            txtAIPlayers.Visible = false;
            txtHumanPlayers.Visible = false;
            lblHumans.Visible = false;
            label2.Visible = false;
      }

      private void label4_Click(object sender, EventArgs e)
      {

      }

      private void rdbYes_CheckedChanged(object sender, EventArgs e)
      {
         if (rdbYes.Checked == true)
         {
            lblItems.Visible = true;
            txbItems.Visible = true;
         }
         else
         {
            lblItems.Visible = false;
            txbItems.Visible = false;
         }
      }
   }
}
