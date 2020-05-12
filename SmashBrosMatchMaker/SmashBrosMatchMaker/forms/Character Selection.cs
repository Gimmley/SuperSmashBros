using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SmashBrosMatchMaker.MatchInfo;
using SmashBrosMatchMaker.forms;

namespace SmashBrosMatchMaker
{
    public partial class CharacterSelection : Form
    {
        IOControl controller;
        public int numPlayers { get; set; }

        public bool isItems { get; set; }

        public int itemPercent { get; set; }
      public CharacterSelection()
        {
            InitializeComponent();
        }
        public void makeVisible()
        {
            if (numPlayers == 8)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                lblPlayer6.Visible = true;
                lblPlayer7.Visible = true;
                lblPlayer8.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;
                cmbPlayer7.Visible = true;
                cmbPlayer8.Visible = true;

            }
            else if (numPlayers == 7)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                lblPlayer6.Visible = true;
                lblPlayer7.Visible = true;
                

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;
                cmbPlayer7.Visible = true;
                
            }
            else if (numPlayers == 6)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                lblPlayer6.Visible = true;
                

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;
                
            }
            else if (numPlayers == 5)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                
            }
            else if (numPlayers == 4)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
            }
            else if (numPlayers == 3)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Character> characterList = new List<Character>();
            if(numPlayers == 2)
            {
                characterList.Add(new Character(1, cmbPlayer1.SelectedItem.ToString()));
                characterList.Add(new Character(2, cmbPlayer2.SelectedItem.ToString()));
            }
            else if(numPlayers == 3)
            {
                characterList.Add(new Character(3, cmbPlayer3.SelectedItem.ToString()));
            }
            else if (numPlayers == 4)
            {
                characterList.Add(new Character(4, cmbPlayer4.SelectedItem.ToString()));
            }
            else if (numPlayers == 5)
            {
                characterList.Add(new Character(5, cmbPlayer5.SelectedItem.ToString()));
            }
            else if (numPlayers == 6)
            {
                characterList.Add(new Character(6, cmbPlayer6.SelectedItem.ToString()));
            }
            else if (numPlayers == 6)
            {
                characterList.Add(new Character(6, cmbPlayer6.SelectedItem.ToString()));
            }
            else if (numPlayers == 7)
            {
                characterList.Add(new Character(7, cmbPlayer7.SelectedItem.ToString()));
            }
            else if (numPlayers == 8)
            {
                characterList.Add(new Character(8, cmbPlayer8.SelectedItem.ToString()));
            }
            controller.SetCharList(characterList);
        }
    }
}
