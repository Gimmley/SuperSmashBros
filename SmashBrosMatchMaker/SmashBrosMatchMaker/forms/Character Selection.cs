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
using SmashBrosMatchMaker.Database.Entities;
using SmashBrosMatchMaker.forms;
using SmashBrosMatchMaker.MatchInfo;

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

        Match match = new Match();

        List<ComboBox> characterBoxes = new List<ComboBox>();
        List<TextBox> NameBoxes = new List<TextBox>();
        List<Label> nameLabel = new List<Label>();
        List<Label> numberLabel = new List<Label>();
        List<RadioButton> buttonList = new List<RadioButton>();
        public CharacterSelection()
        {
            InitializeComponent();
            populateLists();
        }
        public void populateLists()
        {
            characterBoxes.Add(cmbChar1);
            characterBoxes.Add(cmbChar2);
            characterBoxes.Add(cmbChar3);
            characterBoxes.Add(cmbChar4);
            characterBoxes.Add(cmbChar5);
            characterBoxes.Add(cmbChar6);
            characterBoxes.Add(cmbChar7);
            characterBoxes.Add(cmbChar8);

            characterBoxes.Add(cmbPlayerList1);

            nameLabel.Add(lblChoosePlayer1);
            nameLabel.Add(lblChoosePlayer2);
            nameLabel.Add(lblChoosePlayer3);
            nameLabel.Add(lblChoosePlayer4);
            nameLabel.Add(lblChoosePlayer5);
            nameLabel.Add(lblChoosePlayer6);
            nameLabel.Add(lblChoosePlayer7);
            nameLabel.Add(lblChoosePlayer8);

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

            buttonList.Add(rdbAI1);
            buttonList.Add(rdbAI2);
            buttonList.Add(rdbAI3);
            buttonList.Add(rdbAI4);
            buttonList.Add(rdbAI5);
            buttonList.Add(rdbAI6);
            buttonList.Add(rdbAI7);
            buttonList.Add(rdbAI8);
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
            
            foreach (Label label in numberLabel)
            {
                if (label.Name.Contains((i + 1).ToString()) && i < numPlayers)
                {
                    label.Visible = true;
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
                                if (label.Text.Contains("AI"))
                                {
                                    Database.Entities.Player p = new Database.Entities.Player
                                    {
                                        PlayerName = box.Text,
                                        PlayerTypeId = 2,
                                    };
                                    match.playerList.Add(p);
                                }
                                    
                                if (label.Text.Contains("Human"))
                                {
                                    Database.Entities.Player p = new Database.Entities.Player
                                    {
                                        PlayerName = box.Text,
                                        PlayerTypeId = 1,
                                    };
                                    match.playerList.Add(p);
                                }
                                    
                            }
                        }
                        
                        foreach (ComboBox cmbBox in characterBoxes)
                        {
                          if
                          Database.DatabaseContext.Instance.CharacterTable.Where(foundChar => foundChar.CharacterName == cmbStageType.SelectedItem.ToString()).First();
                                

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
                        if (cmbBox.Name.Contains(i.ToString()))
                        {

                            //playerList[player.playerID - 1].addCharacter(new Character(cmbBox.SelectedItem.ToString()));
                            //playerList[player.playerID - 1].currentCharacter = new Character(cmbBox.SelectedItem.ToString());
                        }
                        i++;
                    }
                    
                }
                //stage = new Stage(cmbStage.SelectedItem.ToString(), cmbStageType.SelectedItem.ToString());
                Stage stage = Database.DatabaseContext.Instance.Stage.Where(foundStage => foundStage.StageName == cmbStage.SelectedItem.ToString()).First();
                StageType stageType = Database.DatabaseContext.Instance.StageType.Where(foundtype => foundtype.StageTypeName == cmbStageType.SelectedItem.ToString()).First();
            }
                

            
            this.Hide();
            controller.openChooseWinner(numPlayers,stage);
        }

        private void bttCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
