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
        public int humanPlayers { get; set; }
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

            nameLabel.Add(lblname1);
            nameLabel.Add(lblname2);
            nameLabel.Add(lblname3);
            nameLabel.Add(lblname4);
            nameLabel.Add(lblname5);
            nameLabel.Add(lblname6);
            nameLabel.Add(lblname7);
            nameLabel.Add(lblname8);

            nameLabel.Add(lblChar1);
            nameLabel.Add(lblChar2);
            nameLabel.Add(lblChar3);
            nameLabel.Add(lblChar4);
            nameLabel.Add(lblChar5);
            nameLabel.Add(lblChar6);
            nameLabel.Add(lblChar7);
            nameLabel.Add(lblChar8);

            numberLabel.Add(lblPlayer1);
            numberLabel.Add(lblPlayer2);
            numberLabel.Add(lblPlayer3);
            numberLabel.Add(lblPlayer4);
            numberLabel.Add(lblPlayer5);
            numberLabel.Add(lblPlayer6);
            numberLabel.Add(lblPlayer7);
            numberLabel.Add(lblPlayer8);
        }
        public void newGame()
        {
            foreach (TextBox txt in NameBoxes)
                txt.ReadOnly = true;
            lblError.Text = "";
        }
        public void makeVisible()
        {
            int i = 0;
            foreach(TextBox box in NameBoxes )
            {
                if(box.Name.Contains((i+1).ToString()) && i < numPlayers)
                {
                    box.Visible = true;
                }
                i++;
            }
            i = 0;
            foreach (ComboBox box in characterBoxes)
            {
                if (box.Name.Contains((i + 1).ToString()) && i < numPlayers)
                {
                    box.Visible = true;
                }
                i++;
            }
            i = 0;
            int charCount = 0;
            foreach (Label label in nameLabel)
            {
                if (label.Name.Contains((i + 1).ToString()) && i < numPlayers)
                {
                    label.Visible = true;
                }
                i++;
                if (label.Name.Contains("Char"+(charCount + 1).ToString()) && charCount < numPlayers)
                {
                    label.Visible = true;
                    charCount++;
                }
                
            }
            i = 0;
            int aiCount = 1;
            foreach (Label label in numberLabel)
            {
                if (label.Name.Contains((i + 1).ToString()) && i < numPlayers)
                {
                    label.Visible = true;
                }
                if (i < humanPlayers)
                    label.Text = "Human " + (i+1).ToString();
                else
                {
                    label.Text = "AI " + (aiCount).ToString();
                    aiCount++;
                }   
                i++;
            }

        }
        private bool isEmpty()
        {
            
            foreach (TextBox box in NameBoxes)
            {
                if (box.Text == "" && box.Visible == true)
                {
                    return true;
                }
                
            }
            foreach (ComboBox box in characterBoxes)
            {
                if (box.SelectedItem == null && box.Visible == true)
                {
                    return true;
                }
            }
            if (cmbStage.SelectedItem == null)
                return true;
            else if (cmbStageType.SelectedItem == null)
                return true;
            else
                return false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                lblError.Text = "Please do not leave any options empty";
                return;
            }
            Stage stage;
            List<Player> playerList = new List<Player>();
            int i = 1;
            if(firstGame)
            {
                foreach (TextBox box in NameBoxes)
                {

                    if (box.Visible == true)
                    {
                        foreach(Label label in numberLabel)
                        {
                            if(label.Name.Contains(i.ToString()))
                            {
                                if(label.Text.Contains("AI"))
                                    playerList.Add(new Player(i, box.Text, "AI"));
                                if (label.Text.Contains("Human"))
                                    playerList.Add(new Player(i, box.Text, "Human"));
                            }
                        }
                        
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
                stage = new Stage(cmbStage.SelectedItem.ToString(),cmbStageType.SelectedItem.ToString());
                
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
                stage = new Stage(cmbStage.SelectedItem.ToString(), cmbStageType.SelectedItem.ToString());
                
            }
                

            
            this.Hide();
            controller.openChooseWinner(numPlayers,stage);
        }


    }
}
