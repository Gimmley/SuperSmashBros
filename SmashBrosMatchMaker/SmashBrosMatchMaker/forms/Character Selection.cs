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

        public Match match = new Match();
        

        List<ComboBox> characterBoxes = new List<ComboBox>();

        List<ComboBox> playerBoxes = new List<ComboBox>();
        List<Label> nameLabel = new List<Label>();
        List<Label> numberLabel = new List<Label>();
        
        public CharacterSelection()
        {
            InitializeComponent();
            populateLists();
            importDatabase();
        }
        public void importDatabase()
        {
            List<Player> tempList = new List<Player>();
            
            tempList = Database.DatabaseContext.Instance.Player.ToList();

            foreach (ComboBox box in playerBoxes)
            {
                box.SelectedItem = null;
                box.Items.Clear();
            }

            foreach (Player player in tempList)
            {
                foreach (ComboBox box in playerBoxes)
                {

                    box.Items.Add(player.PlayerName);
                }
            }
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

            playerBoxes.Add(cmbPlayerList1);
            playerBoxes.Add(cmbPlayerList2);
            playerBoxes.Add(cmbPlayerList3);
            playerBoxes.Add(cmbPlayerList4);
            playerBoxes.Add(cmbPlayerList5);
            playerBoxes.Add(cmbPlayerList6);
            playerBoxes.Add(cmbPlayerList7);
            playerBoxes.Add(cmbPlayerList8);

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


        }
        public void newGame()
        {
            
            lblError.Text = "";
        }
        public void makeVisible()
        {
            int i = 0;
            foreach (ComboBox box in characterBoxes)
            {
                if (box.Name.Contains((i + 1).ToString()) && i < numPlayers)
                {
                    box.Visible = true;
                }
                i++;
            }
            i = 0;
            foreach (ComboBox box in playerBoxes)
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
            foreach (ComboBox box in characterBoxes)
            {
                if (box.SelectedItem == null && box.Visible == true)
                {
                    return true;
                }
            }
            foreach (ComboBox box in playerBoxes)
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
        private void duplicateCheck(ComboBox check)
        {
            foreach (ComboBox list in playerBoxes)
            {
                if(check != list && check.SelectedItem == list.SelectedItem)
                {
                    list.SelectedItem = null;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            match.numPlayers = numPlayers;
            if(isEmpty())
            {
                lblError.Text = "Please do not leave any options empty";
                return;
            }
            
            
            int i = 1;
            
            foreach (ComboBox box in playerBoxes)
            {

                if (box.Visible == true)
                {
                    Player p = Database.DatabaseContext.Instance.Player.Where(foundPlayer => foundPlayer.PlayerName == box.SelectedItem.ToString()).First();
                    match.playerList.Add(p);
                    foreach (ComboBox cmbBox in characterBoxes)
                    {
                        if(box.Name.Contains(i.ToString()) && cmbBox.Name.Contains(i.ToString()))
                        {
                             CharacterTable newChar = Database.DatabaseContext.Instance.CharacterTable.Where(foundChar => foundChar.CharacterName == cmbBox.SelectedItem.ToString()).First();
                             match.addCharacter(p, newChar);
                        }
                          
                    }
                    i++;
                }
            }
            Stage s = Database.DatabaseContext.Instance.Stage.Where(foundStage => foundStage.StageName == cmbStage.SelectedItem.ToString()).First();
            match.stageList.Add(s);
            this.Hide();
            controller.openChooseWinner(match);
        }

        private void bttCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.openCreationScreen(match);
        }

        private void cmbPlayerList1_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList1);
        }

        private void cmbPlayerList2_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList2);
        }

        private void cmbPlayerList3_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList3);
        }

        private void cmbPlayerList4_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList4);
        }

        private void cmbPlayerList5_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList5);
        }

        private void cmbPlayerList6_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList6);
        }

        private void cmbPlayerList7_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList7);
        }

        private void cmbPlayerList8_DropDownClosed(object sender, EventArgs e)
        {
            duplicateCheck(cmbPlayerList8);
        }
    }
}
