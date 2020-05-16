using SmashBrosMatchMaker.Database.Entities;
using SmashBrosMatchMaker.MatchInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data;


namespace SmashBrosMatchMaker.forms
{
    public sealed class IOControl
    {
        private static readonly object padlock = new object();     
        private static IOControl instance;
        public static IOControl Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new IOControl();
                    }
                    return instance;
                }
            }
        }                                                        //this and above makes class singleton
        Rules rulesForm;
        CharacterSelection selectionForm;
        Choose_Winner chooseWinnerForm;
        Records recordsForm;
        CharacterCreation creationForm;
        public IOControl()
        {
            rulesForm = new Rules();
            selectionForm = new CharacterSelection();
            chooseWinnerForm = new Choose_Winner();
            recordsForm = new Records();
            creationForm = new CharacterCreation();

        }
        public List<Player> GetPlayers()
        {
            return playerList;
            
        }

        List<Player> playerList = new List<Player>();
        
        public void SetPlayerList(List<Player> newPlayers)
        {
            foreach(Player newPlayer in newPlayers)
            {

                playerList.Add(newPlayer);

            }

            
        }
        public void openSelectionScreen(Match match)
        {
            selectionForm.match = match;
            selectionForm.numPlayers = match.numPlayers;
            selectionForm.importDatabase();
            selectionForm.makeVisible();
            selectionForm.Show();
        }
        public void openChooseWinner(Match match)
        {
            
            chooseWinnerForm.setPlayers(match.playerList);
            chooseWinnerForm.fillCombobox();
            chooseWinnerForm.numPlayers = match.numPlayers;
            
            chooseWinnerForm.match = match;
            chooseWinnerForm.Show();
        }

        public void openRecords(Player winner,Match match)
        {
            
            recordsForm.winner = winner;
            recordsForm.fillFields(match);
            recordsForm.Show();
        }

        public void openRules()
        {
           
           rulesForm.Show();
        }
        public void openCreationScreen(Match match)
        {
            creationForm.match = match;
            creationForm.Show();
        }
   }
}
