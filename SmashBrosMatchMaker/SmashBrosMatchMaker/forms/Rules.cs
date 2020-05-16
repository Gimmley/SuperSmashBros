using SmashBrosMatchMaker.forms;
using SmashBrosMatchMaker.MatchInfo;
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
        
        public Match match = new Match();

        public Rules()
        {
            
            InitializeComponent();
        }

        private void bttConfirm_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                return;
            
            int numPlayers;      

            numPlayers = Convert.ToInt32(txtPlayers.Text);

            match.numPlayers = numPlayers;
            if (!isValid())
                return;
            int itemPercent = 0;
            bool isItems;
            if (rdbYes.Checked)
            {
               isItems = true;
               itemPercent = Convert.ToInt32(txbItems.Text);
            }
            else
               isItems = false;
            match.isItems = isItems;
            match.itemPercent = itemPercent;

            if (cmbGameType.SelectedItem.ToString() == "Stock")
            {
                match.MatchType = 1;
            }
            else
                match.MatchType = 2;




            this.Hide();
            controller.openSelectionScreen(match);

        }
        public bool isValid()
        {
            if (match.numPlayers > 8 || match.numPlayers < 2)
            {
                lblError.Text = "Please select a valid number of players";
                return false;
            }
            return true;
        }
        public bool isEmpty()
        {
            int i;
            if (cmbGameType.SelectedItem == null)
            {
                lblError.Text = "Please input valid game type";
                return true;
            }
            if (rdbNo.Checked == false && rdbYes.Checked == false)
            {
                lblError.Text = "Please select if you would like items";
                return true;
            }
            if ( txtPlayers.Visible == false)
                return false;
            if ( txtPlayers.Text == "")
            {
                lblError.Text = "Please input valid number of players";
                return true;
            }
            if ( !int.TryParse(txtPlayers.Text, out i))
            {
                lblError.Text = "Please input valid number of players";
                return true;
            }
            
            return false;
                
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
