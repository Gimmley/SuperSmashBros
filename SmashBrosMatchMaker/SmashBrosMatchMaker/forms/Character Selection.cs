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
        static IOControl controller = IOControl.Instance;
        public int numPlayers { get; set; }

        public bool isItems { get; set; }
        public bool firstGame { set; get; }

        public int itemPercent { get; set; }

        List<ComboBox> characterBoxes = new List<ComboBox>();
        List<TextBox> NameBoxes = new List<TextBox>();
        List<Label> nameLabel = new List<Label>();
        List<Label> numberLabel = new List<Label>();
        public CharacterSelection()
        {
            InitializeComponent();
            populateLists();
        }
        public void populateLists()
        {
            characterBoxes.Add(cmbPlayer1);
            characterBoxes.Add(cmbPlayer2);
            characterBoxes.Add(cmbPlayer3);
            characterBoxes.Add(cmbPlayer4);
            characterBoxes.Add(cmbPlayer5);
            characterBoxes.Add(cmbPlayer6);
            characterBoxes.Add(cmbPlayer7);
            characterBoxes.Add(cmbPlayer8);

            NameBoxes.Add(txtP1Name);
            NameBoxes.Add(txtP2Name);
            NameBoxes.Add(txtP3Name);
            NameBoxes.Add(txtP4Name);
            NameBoxes.Add(txtP5Name);
            NameBoxes.Add(txtP6Name);
            NameBoxes.Add(txtP7Name);
            NameBoxes.Add(txtP8Name);
        }
        public void newGame()
        {
            foreach (TextBox txt in NameBoxes)
                txt.ReadOnly = true;
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

                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;
                lblname4.Visible = true;
                lblname5.Visible = true;
                lblname6.Visible = true;
                lblname7.Visible = true;
                lblname8.Visible = true;


                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;
                cmbPlayer7.Visible = true;
                cmbPlayer8.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
                txtP4Name.Visible = true;
                txtP5Name.Visible = true;
                txtP6Name.Visible = true;
                txtP7Name.Visible = true;
                txtP8Name.Visible = true;
                



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
                
                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;
                lblname4.Visible = true;
                lblname5.Visible = true;
                lblname6.Visible = true;
                lblname7.Visible = true;


                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;
                cmbPlayer7.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
                txtP4Name.Visible = true;
                txtP5Name.Visible = true;
                txtP6Name.Visible = true;
                txtP7Name.Visible = true;

            }
            else if (numPlayers == 6)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                lblPlayer6.Visible = true;

                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;
                lblname4.Visible = true;
                lblname5.Visible = true;
                lblname6.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;
                cmbPlayer6.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
                txtP4Name.Visible = true;
                txtP5Name.Visible = true;
                txtP6Name.Visible = true;

            }
            else if (numPlayers == 5)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;

                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;
                lblname4.Visible = true;
                lblname5.Visible = true;


                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;
                cmbPlayer5.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
                txtP4Name.Visible = true;
                txtP5Name.Visible = true;

            }
            else if (numPlayers == 4)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;

                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;
                lblname4.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;
                cmbPlayer4.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
                txtP4Name.Visible = true;
            }
            else if (numPlayers == 3)
            {
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;

                lblname1.Visible = true;
                lblname2.Visible = true;
                lblname3.Visible = true;

                cmbPlayer1.Visible = true;
                cmbPlayer2.Visible = true;
                cmbPlayer3.Visible = true;

                txtP1Name.Visible = true;
                txtP2Name.Visible = true;
                txtP3Name.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Player> playerList = new List<Player>();
            int i = 1;
            if(firstGame)
            {
                foreach (TextBox box in NameBoxes)
                {

                    if (box.Visible == true)
                    {
                        playerList.Add(new Player(i, box.Text));
                        foreach (ComboBox cmbBox in characterBoxes)
                        {
                            if (cmbBox.Name.Contains(i.ToString()))
                            {

                                playerList[i - 1].addCharacter(new Character(cmbBox.SelectedItem.ToString()));
                                playerList[i - 1].currentCharacter = new Character(cmbBox.SelectedItem.ToString());
                            }
                        }
                        i++;
                    }
                }
                controller.SetPlayerList(playerList);
            }
            else
            {
                playerList = controller.GetPlayers();
                foreach (Player player in playerList)
                {
                    
                    foreach (ComboBox cmbBox in characterBoxes)
                    {
                        if (cmbBox.Name.Contains(player.playerID.ToString()))
                        {

                            playerList[player.playerID - 1].addCharacter(new Character(cmbBox.SelectedItem.ToString()));
                            playerList[player.playerID - 1].currentCharacter = new Character(cmbBox.SelectedItem.ToString());
                        }
                    }
                    
                }
            }
                

            
            this.Hide();
            controller.openChooseWinner(numPlayers);
        }
    }
}
